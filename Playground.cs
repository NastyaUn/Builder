using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    //объявляет создающие методы для различных частей объектов Продуктов.
    public abstract class Playground
    {
        virtual public void CreateFence() { }//Ограда
        virtual public void CreateNetwork() { }//Сеть
        virtual public void CreatePillars() { }//Столбы для сети
        virtual public void CreateMapping() { }//Разметка
    }
}
