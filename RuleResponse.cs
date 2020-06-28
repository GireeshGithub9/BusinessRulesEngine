using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRulesEngine
{
    public class RuleResponse
    {
        //Responses for each Order types 
        public bool EmailSent { get; set; }
        public bool ComissionCredited { get; set; }
        public bool BookOrder { get; set; }
        public bool LearnToSki { get; set; }
        public bool NewMembership { get; set; }
        public bool UpgradeMembership { get; set; }

    }
}
