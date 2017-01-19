using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSpeckmann.Resolver.DNS
{
    class Packet
    {
        public Header Header { get; set; }
        public List<Question> QuestionSection { get; set; }
        public List<Answer> AnswerSection { get; set; }
        public List<Authority> AuthoritySection { get; set; }
        public List<Additional> AdditionalSection { get; set; }
        
        public Packet()
        {
            Header = new Header();
            QuestionSection = new List<Question>();
            AnswerSection = new List<Answer>();
            AuthoritySection = new List<Authority>();
            AdditionalSection = new List<Additional>();
        }
    }
}
