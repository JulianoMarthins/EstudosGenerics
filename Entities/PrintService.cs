using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testes.Entities {
    internal class PrintService<Generic> {

        private Generic[] values = new Generic[10];
        private int count = 0;


        public void AddValue (Generic value) {
            if (count == 10) {
                throw new InvalidOperationException("PrintService is full");
            }

            values[this.count] = value;
            count++;
        }

        public Generic First () {
            if (count == 0) {
                throw new InvalidOperationException("PrintService is empty");
            }

            return values[0];
        }

        public void Print () {
            Console.Write("All Values: [");

            for (int i = 0; i < count - 1; i++) {
                Console.Write(values[i] + ", ");
            }

            Console.WriteLine(values[count - 1] + "]");

        }
    }
}
