//Auteur : François Corneau-Tremblay

#ifndef COMPTBANQ_H
#define COMPTBANQ_H

#include <iostream>

class comptBanq {
	public :
		//Default initialization of values
		comptBanq() : solde(0), id(comptBanq::new_id()) {}
	
		//Returns the current value of next_id_available and increments afterward
		static int new_id()
		{
			int id_to_give = next_id_available;
			next_id_available++;
			
			return id_to_give;
		}
		
		int current_id() { return id; }
		double current_solde() { return solde; }

		//Adds the amount of money given
		void make_deposit(double amount) { solde += amount;}
		
		//Substracts the amount of money given. Since no specification was given on whether or not it could go
		//into the negative, no check is made. But the function returns a boolean in case of future specification
		//where this could fail
		bool make_withdrawal(double amount) 
		{
			solde -= amount;
			return true;
		}
		
		//Gives the current id and amount of money
		void print()
		{
			std::cout << "ID : " << current_id() << '\n';
			std::cout << "Solde : " << current_solde() << "$ \n";
		}
		
	protected:
		static int next_id_available;
		
		int id;
		double solde;
};

class comptChec	: public comptBanq 
{
	public :
		//Implements a new checking account
		comptChec(double _min_solde, double _serv_fees, double _month_fees) : minimum_solde(_min_solde),
																	service_fees(_serv_fees), monthly_fees(_month_fees)
																	{}
																	
		double current_mininum_solde() { return minimum_solde; }
		void set_minimum_solde(double new_minimum) { minimum_solde = new_minimum; }
		
		void set_monthly_fees(double new_monthly_fees) { monthly_fees = new_monthly_fees; }
		
		//Since there is no notion of time in this TP, I supposed the monthly_fees and the service_fees
		//applied at the moment the account goes under
		bool make_withdrawal(double amount)
		{
			solde -= amount;
			
			if(solde < minimum_solde)
				solde -= monthly_fees + service_fees;
			
			return  true;
		}
		
		void print()
		{
			comptBanq::print();
			
			std::cout << "Le montant minimum du compte est : " << minimum_solde << "$ \n";
			std::cout << "Le montant des frais mensuels du compte est : " << monthly_fees << "$ \n";
			std::cout << "Le montant des frais de services du compte est : " << service_fees << "$ \n";
		}
	private : 
		double minimum_solde;
		double service_fees;
		double monthly_fees;
};

class comptEpargn : public comptBanq 
{
	public :
		comptEpargn(double _interest_rate) : interest_rate(_interest_rate) {}
		
		void set_interest_rate(double new_interest_rate) { interest_rate = new_interest_rate; }
	private :
		double interest_rate;
};

#endif





