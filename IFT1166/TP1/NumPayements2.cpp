//Auteur : François Corneau-Tremblay

#include <iomanip>
#include <iostream>
#include <cmath>

using std::cout;
using std::cin;
using std::endl;


int main(int argc, char** argv)
{
	float loan_amount, yearly_intereste_rate, 
		monthly_payment, monthly_interest_rate, 
		months_until_payment, covered_percent_per_month,
		minimum_payment_per_month, total_interest_paid;

	cout << std::fixed;
	cout << std::setprecision(2);
		
	//Saisie des entrées pour le calcul du remboursement du paiement
	cout << "Entrez le montant emprunte : " << endl;
	cin >> loan_amount;
	cout << "Entrez le taux d'interet par an : " << endl;
	cin >> yearly_intereste_rate;
	
	//Conversion du pourcentage d'intérêt par année à un taux d'intérêt mensuel. ("Pourcentage par an" / "Nombre de mois dans une année") / 100
	//pour obtenir un nombre décimal non fractionnel
	monthly_interest_rate = (yearly_intereste_rate / 12) / 100;
	
	//Calcul du montant minimum par mois en ce basant sur la formule P = r * A, obtenu en posant
	// 1 - ((r * A ) / P) >= 0
	// et on isolant P pour trouver le montant minimum
	minimum_payment_per_month = monthly_interest_rate * loan_amount;
	
	cout << "Le paiement minimum a effectuer est : " << minimum_payment_per_month << endl;
	
	cout << "Entrez le montant du paiement par mois : " << endl;
	cin >> monthly_payment;
	
	//Pourcentage couvert par mois selon le paiement mensuel
	covered_percent_per_month = 1 - ((monthly_interest_rate * loan_amount) / monthly_payment);
	//Si le montant payé par mois couvre moins que les intérêts il sera impossible de rembourser ce paiement
	if(covered_percent_per_month <= 0)
	{
		cout << "Il est impossible de rembourser ce montant avec ce paiement mensuel" << endl;
		return -1;
	}
	
	/* Suivant l'équation P = ( r * A ) / ( 1 - ( 1 + r) ^ -N)
		où 
		P : Montant par mois
		A : Montant de l'emprunt
		r : taux d'intérêt
		N : Nombre d'unités temporelles (Dépendant du taux d'intérêt; an, mois, semaine, ...)
		on peut déduire que N = -1 * (log((1 - (r * A )/ P)) / log(1 + r)
	*/
	months_until_payment = -(std::log(covered_percent_per_month) / 
							std::log(1.0f + monthly_interest_rate));
							
	//Pour calculer le total d'intérêt payer, il faut mutliplier le taux d'intérêt par le montant payé par mois puis par le nombre de période
	total_interest_paid = loan_amount * monthly_interest_rate * ceil(months_until_payment);
							
	//Le nombre de mois avant la fin du paiement doit prendre compte de la décimale
	//Il faudra 24 mois pour rembourser un emprunt remboursable en 23.4662 mois
	//On arrondi donc vers le haut
	cout << "Le montant emprunte sera rembourse dans " << ceil(months_until_payment) << " mois." << endl;
	cout << "Suite à quoi vous aurez payer " << total_interest_paid << "$ en intérêts" << endl;
	
	//
	cout << "Montant du dernier paiement : " << (monthly_payment * (months_until_payment - floor(months_until_payment))) << "$" << endl;
	
	return 0;
}

float calculate_interest(float rate, float loan_amount, float monthly_payment)
{
	float interest_paid = loan_amount * rate;
	float total_interest = interest_paid;
	float current_payment_on_loan = monthly_payment - interest_paid;
	
	while(loan_amount - current_payment_on_loan > 0)
	{
		loan_amount -= current_payment_on_loan;
		interest_paid = loan_amount * rate;
		current_payment_on_loan = monthly_payment - interest_paid;
		total_interest += interest_paid;
	}
	
	interest_paid = loan_amount * rate;
	total_interest += interest_paid;
	monthly_payment = loan_s

	return total_interest;
}

//Résultat d'exécution
/*
Entrez le montant emprunte :
1000
Entrez le taux d'interet par an :
6.2
Le paiement minimum a effectuer est : 5.17
Entrez le montant du paiement par mois :
10
Le montant emprunte sera rembourse dans 142.00 mois.
Suite à quoi vous aurez payer 992.71$ en intérêts
Montant du dernier paiement : 0.83$
*/