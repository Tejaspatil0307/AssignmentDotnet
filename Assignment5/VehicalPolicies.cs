using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    abstract class VehicalPolicies
    {
        public string PolicyNo { get; set; }
        public double InsuredAmount { get; set; }
        public string VehicalType { get; set; }

        public VehicalPolicies(string policyNo, double  insuredAmount,string vehicalType) {
            PolicyNo = policyNo;
            InsuredAmount = insuredAmount;
            VehicalType=vehicalType;   
        }
       public abstract  double CalculatePremium();
    }
     class TwoWheelerPolicies : VehicalPolicies
    {
        public TwoWheelerPolicies(string policyNo,double insuredAmount,string vehicalType) : base(policyNo,insuredAmount,"Twowheeler") 
        { 
        }
        public override double CalculatePremium()
        {
            return InsuredAmount * 0.02;
        }

    }
     class FourWheelerpolicies : VehicalPolicies
    {
        public FourWheelerpolicies(string policyNo, double insuredAmount, string vehicalType) : base(policyNo, insuredAmount, "Four Vheeler") { 
        
        }
        public override double CalculatePremium() {
            return InsuredAmount * 0.06;

        }
    }
     class Commercial : VehicalPolicies 
    {
        public Commercial(string policyNo, double insuredAmount, string vehicalType) : base(policyNo, insuredAmount, "Commercial") { 
        
        }
        public override double CalculatePremium()
        {
            return InsuredAmount * 0.08;
        }
    }
    }



