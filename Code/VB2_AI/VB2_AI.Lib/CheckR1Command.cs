using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VB2_AI.Lib
{
    class CheckR1Command : IRuleCheckCommand
    {
        private readonly char[] _content;
        private readonly int _type;

        public CheckR1Command(char[] content, int type)
        {
            this._content = content;
            this._type = type;
        }
        public bool Check()
        {
            switch (_type)
            {
                case 1:
                    {
                        var dimp1 = Syllogism.Quantifiers.FirstOrDefault(x => x.Symbol.Equals(_content[0])).DIS;
                        var dimp2 = Syllogism.Quantifiers.FirstOrDefault(x => x.Symbol.Equals(_content[1])).DIP;
                        return dimp1 + dimp2 > 5;
                    }
                case 2:
                    {
                        var dimp1 = Syllogism.Quantifiers.FirstOrDefault(x => x.Symbol.Equals(_content[0])).DIP;
                        var dimp2 = Syllogism.Quantifiers.FirstOrDefault(x => x.Symbol.Equals(_content[1])).DIP;
                        return dimp1 + dimp2 > 5;
                    }
                case 3:
                    {
                        var dimp1 = Syllogism.Quantifiers.FirstOrDefault(x => x.Symbol.Equals(_content[0])).DIS;
                        var dimp2 = Syllogism.Quantifiers.FirstOrDefault(x => x.Symbol.Equals(_content[1])).DIS;
                        return dimp1 + dimp2 > 5;
                    }
                case 4:
                    {
                        var dimp1 = Syllogism.Quantifiers.FirstOrDefault(x => x.Symbol.Equals(_content[0])).DIP;
                        var dimp2 = Syllogism.Quantifiers.FirstOrDefault(x => x.Symbol.Equals(_content[1])).DIS;
                        return dimp1 + dimp2 > 5;
                    }
                default:
                    return false;                    
            }            
        }
    }
}
