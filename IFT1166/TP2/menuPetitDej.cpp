//François Corneau-Tremblay

#include <iostream>
#include <fstream>
#include <string>
#include <vector>
#include <sstream>
#include <map>
#include <algorithm>
#include <iomanip>

using std::cout;
using std::cin;

//Basic struct for a menu element. Contains a name (elem) and a price (prix)
struct elemMenu {
	
	elemMenu(const std::string& _elem, double _prix) : elem(_elem), prix(_prix) {}
	
	std::string elem;
	double prix;
};

//Structs don't have a default comparison operator so this defines one for elemMenu
//comparison is done inside the std::count function later on
bool operator==(const elemMenu& lhs, const elemMenu& rhs)
{
	return lhs.elem == rhs.elem && lhs.prix == rhs.prix;
}

std::vector<elemMenu> chargerMenu();
void affichMenu(const std::vector<elemMenu>&);
void affichFact(const std::vector<elemMenu>&, const std::vector<elemMenu>&);


int main(int argc, char** argv)
{
	//Creates a vector of element containing all the menu elements
	std::vector<elemMenu> menu_elements = chargerMenu();
	//Represents the client's chosen elements
	std::vector<elemMenu> cart;
	
	std::string input_value;
	int chosen_element;

	//Prints the content of menu_elements vector as the menu
	affichMenu(menu_elements);
	
	cin >> input_value;
	//As long as the user does not want to quit, loop over the choice mechanic
	while(input_value != "quitter")
	{
		//Parsing a number can lead to some invalid behavior, so this section is inside this try/catch
		//block to prevent an user to enter some things like "DF"G/$gm43ogo3m r11
		try {
			//Converts the chosen element to an integer value
			chosen_element = stoi(input_value);
			
			//If the element is greater or equal to the menu elements size, it means that it's invalid
			//So throw an exception for that
			if(chosen_element >= menu_elements.size())
				throw std::invalid_argument("");

			//Add the element to the cart
			cart.push_back(menu_elements[chosen_element]);
			
			cout << "Vous avez ajouté : " << menu_elements[chosen_element].elem << " à votre panier \n";
		}
		
		catch(const std::invalid_argument& e)
		{
			cout << "Vous n'avez pas rentré une valeur valide. Réésayer. \n";
		}
		
		cin >> input_value;
	}
	
	affichFact(cart, menu_elements);
	
	return 0;
}

std::vector<elemMenu> chargerMenu()
{
	//A vector containing the actual elements
	std::vector<elemMenu> menu;
	//Some buffer to store each line of the file
	std::vector<std::string> buffer;
	
	//Opens the file and check if the operation has failed, in which case, return an empty vector
	std::ifstream menu_file("MenuRestoIFT1166.txt");
	if (menu_file.fail()) {
		cout << "Impossible d’ouvrir le fichier menu." << "\n";
		return std::vector<elemMenu>();
	}

	//Since each line correspond to either a name or a price, store each one inside the vector
	std::string line;
	while (std::getline(menu_file, line))
		buffer.push_back(line);
	
	//Dont forget to close the menu since we're not using RAII
	menu_file.close();

	//Since all the names are on even lines and all the prices are on odd lines, start at zero
	//and increment i by two so that it always represent a name's position. Which will also means
	//that i + 1 will always be the price of the element with that name
	for(int i = 0; i < buffer.size(); i += 2)
		menu.push_back(elemMenu(buffer[i], atof(buffer[i + 1].c_str())));
	
	return menu;
}

//Simply loops over the menu vector and prints its content
void affichMenu(const std::vector<elemMenu>& menu)
{
	cout << "Voici les éléments du menu : " << "\n";
	
	for(int i = 0; i < menu.size(); ++i)
		cout << i << ") " << menu[i].elem << " : " << menu[i].prix << "$ \n";
	
	cout << "Vous pouvez ajouter un élément à votre panier en rentrant son numéro. Pour quitter, tapez 'quitter' \n";
}

void affichFact(const std::vector<elemMenu>& cart, const std::vector<elemMenu>& menu)
{
	double total = 0.0;
	double taxes = 0.0;
	
	//Used to see how many of each element the cart contains
	std::map<std::string, int> elem_count;
	
	//Calculate the total
	for(int i = 0; i < cart.size(); ++i)
		total += cart[i].prix;
	
	//Calculate how many of each element there is in the cart
	for(int i = 0; i < menu.size(); ++i)
		elem_count.insert(std::make_pair(menu[i].elem, std::count(cart.begin(), cart.end(), menu[i])));
	
	//Prints some kind of table with all the elements in the car with their price. If the count is zero
	//it means that it's not in the cart so we don't have to print it
	for(int i = 0; i < menu.size(); ++i)
	{
		if(elem_count[menu[i].elem] > 0)
			cout << elem_count[menu[i].elem] << " | " << menu[i].elem << " | " << menu[i].prix << "\n";
	}
	
	taxes = total * 0.14975;
	
	cout << std::fixed;
	cout << std::setprecision(2);
	
	cout << "Taxes : " << taxes << "$\n";
	cout << "Total : " << total << "$\n";
}

/* Compilation - g++ menuPetitDej.cpp -o petitDej 
	Compile passed
	
	Output sample :
	
	$ ./petitDej.exe
	Voici les éléments du menu :
	0) Oeuf : 3.45$
	1) Muffin : 1.99$
	2) Pain grillé : 2.99$
	3) Fruits : 3.49$
	4) Céréales : 1.69$
	5) Café : 1.5$
	6) Thé : 1.75$
	Vous pouvez ajouter un élément à votre panier en rentrant son numéro. Pour quitter, tapez 'quitter'
	0
	Vous avez ajouté : Oeuf à votre panier
	2
	Vous avez ajouté : Pain grillé à votre panier
	4
	Vous avez ajouté : Céréales à votre panier
	3
	Vous avez ajouté : Fruits à votre panier
	3
	Vous avez ajouté : Fruits à votre panier
	3
	Vous avez ajouté : Fruits à votre panier
	quitter
	1 | Oeuf | 3.45
	1 | Pain grillé | 2.99
	3 | Fruits | 3.49
	1 | Céréales | 1.69
	Taxes : 2.79$
	Total : 18.60$

*/