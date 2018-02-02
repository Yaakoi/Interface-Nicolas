using Pic.Plugin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Nicolas
{
    class GetProperties
    {
        ParameterStack _pStack;
        public GetProperties(Component comp)
        {
            ParameterStack pStack = new ParameterStack();
            pStack = comp.BuildParameterStack(pStack);
            _pStack = pStack;
        }
        
        public void getProp()
        {
            List<Parameter> listParam = new List<Parameter>();
            //_pStack.GetParameterByName
            
        }
    }
}
