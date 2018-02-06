using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pic.Plugin;

namespace Interface_Nicolas
{
    class LoadProfile : ProfileLoader
    {
        public override double Thickness => throw new NotImplementedException();

        public override void BuildCardboardProfile()
        {
            throw new NotImplementedException();
        }

        public override void EditMajorations()
        {
            throw new NotImplementedException();
        }

        public override void SetComponent(Component comp)
        {
            throw new NotImplementedException();
        }

        protected override Dictionary<string, double> LoadMajorationList()
        {
            throw new NotImplementedException();
        }

        protected override Profile[] LoadProfiles()
        {
            throw new NotImplementedException();
        }
    }
}
