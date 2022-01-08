using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class TennisCourt : Playground
    {
        private Product _product = new Product();

        // Новый экземпляр строителя который используется в дальнейшей сборке.
        public TennisCourt()
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
            this._product.Add("Ограждение 28*17 ярдов");
        }

        public override void CreateNetwork()
        {
            this._product.Add("Теннисная сеть");
        }

        public override void CreatePillars()
        {
            this._product.Add("Столбы для сети высотой 1 ярд");
        }
        public override void CreateMapping()
        {
            this._product.Add("Разметка для теннисной  площадки 26*9 ярдов");
        }
        // вызов метода сброса в конце тела метода GetProduct
        public Product GetProduct()
        {
            Product result = this._product;

            this.Reset();

            return result;
        }
    }
}
