//Auteur : François Corneau-Tremblay

#include "comptBanq.h"

using std::cout;

int comptBanq::next_id_available = 0;

int main(int argc, char** argv)
{
	comptBanq banking_account;
	comptChec checking_account(200, 10, 3);
	comptEpargn savings_account(0.03);
	
	cout << "Compte normal \n";
	//Basic bank account test
	banking_account.print();
	cout << banking_account.current_id() << '\n';
	cout << banking_account.current_solde() << '\n';
	
	banking_account.make_deposit(1000);
	banking_account.print();
	banking_account.make_withdrawal(800);
	banking_account.print();
	
	cout << "\nCompte chèque \n";
	//Checking account test
	checking_account.print();
	cout << checking_account.current_id() << '\n';
	cout << checking_account.current_solde() << '\n';
	cout << checking_account.current_mininum_solde() << '\n';
	
	checking_account.make_deposit(1000);
	checking_account.print();
	checking_account.make_withdrawal(800);
	checking_account.print();
	checking_account.set_minimum_solde(100);
	checking_account.print();
	checking_account.set_monthly_fees(9);
	checking_account.print();
	
	cout << "\nCompte épargne \n";
	//Savings account test
	savings_account.print();
	cout << savings_account.current_id() << '\n';
	cout << savings_account.current_solde() << '\n';
	
	savings_account.make_deposit(1000);
	savings_account.print();
	savings_account.make_withdrawal(800);
	savings_account.print();
	
	savings_account.set_interest_rate(0.04);
	savings_account.print();
	
	return 0;
}

/*
$ Compilation - g++ comptBanq.cpp -o bank 
	Compile passed
		
		./bank.exe
		Compte normal
		ID : 0
		Solde : 0$
		0
		0
		ID : 0
		Solde : 1000$
		ID : 0
		Solde : 200$

		Compte chèque
		ID : 1
		Solde : 0$
		Le montant minimum du compte est : 200$
		Le montant des frais mensuels du compte est : 3$
		Le montant des frais de services du compte est : 10$
		1
		0
		200
		ID : 1
		Solde : 1000$
		Le montant minimum du compte est : 200$
		Le montant des frais mensuels du compte est : 3$
		Le montant des frais de services du compte est : 10$
		ID : 1
		Solde : 200$
		Le montant minimum du compte est : 200$
		Le montant des frais mensuels du compte est : 3$
		Le montant des frais de services du compte est : 10$
		ID : 1
		Solde : 200$
		Le montant minimum du compte est : 100$
		Le montant des frais mensuels du compte est : 3$
		Le montant des frais de services du compte est : 10$
		ID : 1
		Solde : 200$
		Le montant minimum du compte est : 100$
		Le montant des frais mensuels du compte est : 9$
		Le montant des frais de services du compte est : 10$

		Compte épargne
		ID : 2
		Solde : 0$
		2
		0
		ID : 2
		Solde : 1000$
		ID : 2
		Solde : 200$
		ID : 2
		Solde : 200$


*/