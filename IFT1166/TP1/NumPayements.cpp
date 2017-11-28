//Auteur : François Corneau-Tremblay

#include <iomanip>
#include <iostream>
#include <cmath>

using std::cout;
using std::cin;
using std::endl;


int main(int argc, char** argv)
{
	float loan_amount, yearly_intereste_rate, monthly_payment, monthly_interest_rate, months_until_payment, covered_percent_per_month;
	
	//Saisie des entrées pour le calcul du remboursement du paiement
	cout << "Entrez le montant emprunte : " << endl;
	cin >> loan_amount;
	cout << "Entrez le taux d'interet par an : " << endl;
	cin >> yearly_intereste_rate;
	cout << "Entrez le montant du paiement par mois : " << endl;
	cin >> monthly_payment;
	
	//Conversion du pourcentage d'intérêt par année à un taux d'intérêt mensuel. ("Pourcentage par an" / "NOmbre de mois dans une année") / 100
	//pour obtenir un nombre décimal non fractionnel
	monthly_interest_rate = (yearly_intereste_rate / 12) / 100;
	
	covered_percent_per_month = 1 - ((monthly_interest_rate * loan_amount) / monthly_payment);
	//Si le montant payé par mois couvre moins que les intérêts il sera impossible de rembourser ce paiement
	if(covered_percent_per_month <= 0)
	{
		cout << "Il est impossible de rembourser ce montant avec ce paiement mensuel" << endl;
		return -1;
	}
	
	/*Suivant l'équation P = ( r * A ) / ( 1 - ( 1 + r) ^ -N)
		où 
		P : Montant par mois
		A : Montant de l'emprunt
		r : taux d'intérêt
		N : Nombre d'unités temporelles (Dépendant du taux d'intérêt; an, mois, semaine, ...)
		on peut déduire que N = -1 * (log((1 - (r * A )/ P)) / log(1 + r)
	*/
	months_until_payment = -(std::log(covered_percent_per_month) / 
							std::log(1.0f + monthly_interest_rate));
							
							
	//Le nombre de mois avant la fin du paiement doit prendre compte de la décimale
	//Il faudra 24 mois pour rembourser un emprunt remboursable en 23.4662 mois
	//On arrondi donc vers le haut
	cout << "Le montant emprunte sera rembourse dans " << ceil(months_until_payment) << " mois." << endl;
	
	return 0;
}

//Résultat d'exécution
/*
Entrez le montant emprunte :
200000
Entrez le taux d'interet par an :
2.0
Entrez le montant du paiement par mois :
500
Le montant emprunte sera rembourse dans 660 mois.
*/