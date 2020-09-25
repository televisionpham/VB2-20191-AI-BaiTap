using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VB2_AI.Lib
{
    class CheckR3Command : IRuleCheckCommand
    {
        private readonly char[] _content;

        public CheckR3Command(char[] content)
        {
            this._content = content;            
        }
        public bool Check()
        {
            var p1_quality = Syllogism.Quantifiers.FirstOrDefault(x => x.Symbol.Equals(_content[0])).Quality;
            var p2_quality = Syllogism.Quantifiers.FirstOrDefault(x => x.Symbol.Equals(_content[1])).Quality;

            return p1_quality || p2_quality;
        }
    }
}
