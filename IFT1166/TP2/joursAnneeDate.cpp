#François Corneau-Tremblay

#include <iostream>
#include <string>
#include <tuple>
#include <array>

using std::cin;
using std::cout;

bool estBissextile(int annee);
int joursDansMois(int mois, int annee);
int nombreJours(int jour, int mois, int annee);

//Returns a tuple that contains a parse date as a day, a month and a year
std::tuple<int, int, int> parseDate(const std::string&);

int main(int argc, char** argv)
{
	int annee, mois, jour;
	std::string date;

	cout << "Entrez la date : \n";
	cin >> date;
	
	//Ties the day, the month and the year to the values of the tuple
	std::tie(jour, mois, annee) = parseDate(date);
	
	cout << "Le nombre de jours depuis " << date << " est : " << nombreJours(jour, mois, annee) << "\n";
	return 0;
}

//Format de la date JOUR/MOIS/ANNEE
std::tuple<int, int, int> parseDate(const std::string& date)
{
	//Local copy so that it can be modified
	std::string local_date = date;
	//The delimiter of the date string
	std::string date_delimiter = "/";
	
	int token_position;
	
	//Since there's only three values of interest, create a static array for that much values
	std::array<int, 3> values;
	
	for(int i = 0; i < 3; ++i)
	{
		//Find the position of the delimiter inside the date string
		token_position = local_date.find(date_delimiter);
		
		//By assigning the date to the current_value we don't have to treat the edge case of not having
		//a delimiter for the year part since our local_date should look like this after two iteration
		// "YYYY" with no delimiter
		std::string current_value = local_date;
		if(token_position != std::string::npos) //If the token has actually been found
		{
			//Ge the substring inside the local_date from the start to the delimiter positio
			current_value = local_date.substr(0, token_position);
			//Remove the found value and the delimiter for that value
			local_date.erase(0, token_position + date_delimiter.length());
		}			
		
		//Add the current_value to the values of interest
		values[i] = std::stoi(current_value);
	}
	
	//Return a tuple made from the values of the array
	return std::make_tuple(values[0], values[1], values[2]);
}

bool estBissextile(int annee)
{
	//Check if this can be divided by 100
	if(annee % 100 == 0)
		if(annee % 400 == 0) //If so, check if it can be divided by 400
			return true; //Yes, then this is a leap year
		else
			return false; //No, a simple year
	
	return (annee % 4) == 0; //We already determined that it can't be divided by a 100, no need to check that
}

int joursDansMois(int mois, int annee)
{
	switch(mois) {
		case 1: return 31;
		case 2: return estBissextile(annee) ? 29: 28;
		case 3: return 31;
		case 4: return 30;
		case 5: return 31;
		case 6: return 30;
		case 7: return 31;
		case 8: return 31;
		case 9: return 30;
		case 10: return 31;
		case 11: return 30;
		case 12: return 31;
		default: return 0;
	}
}

int nombreJours(int jour, int mois, int annee)
{
	int total_jour = jour; //Start with the number of days that have passed in the current month
	
	for(int i = 1; i < mois; ++i) //Then add any number of days from the passed months
		total_jour += joursDansMois(i, annee);
	
	return total_jour;
}

/* Compilation - g++ joursAnnesMois.cpp -o jourAnneeMois 
	Compile passed
	
	Output samples :
	$ ./joursAnneeDate.exe
	Entrez la date :
	25/12/2016
	Le nombre de jours depuis 25/12/2016 est : 360
	
	$ ./joursAnneeDate.exe
	Entrez la date :
	01/01/1996
	Le nombre de jours depuis 01/01/1996 est : 1
*/