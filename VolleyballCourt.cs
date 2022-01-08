using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class VolleyballCourt : Playground
    {
        private Product _product = new Product();

        // Новый экземпляр строителя который используется в дальнейшей сборке.
        public VolleyballCourt()
        {
            this.Reset();
        }

        public void Reset()
        {
            this._product = new Product();
        }

        // Все этапы производства работают с одним и тем же экземпляром
        public override void CreateFence()
        {
            this._product.Add("Ограждение 23*14 метров");
        }

        public override void CreateNetwork()
        {
            this._product.Add("Волейбольная сеть");
        }

        public override void CreatePillars()
        {
            this._product.Add("Столбы для сети высотой 2.5 метра");
        }
        public override void CreateMapping()
        {
            this._product.Add("Разметка для волейбольной площадки 18*9 метров");
        }
        public Product GetProduct()
        {
            Product result = this._product;

            this.Reset();

            return result;
        }
    }
}
