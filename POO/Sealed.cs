﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.POO
{
    class Sealed
    {
        //Classe selada não permite herança
        sealed class SemFilho
        {
            public double ValorDaFortuna()
            {
                return 1.407033;
            }
        }



        /*class SouFilho: SemFilho
        {

 

        }*/



        class Avo
        {
            //métodos virtuais podem ser sobrescritos
            public virtual bool HonrarNomeFamilia()
            {
                return true;
            }
        }

        class Pai: Avo
        {
            public override bool HonrarNomeFamilia()
            {
                return true;
            }
        }

        class FilhoRebelde: Pai
        {
            public override bool HonrarNomeFamilia()
            {
                return false;
            }
        }

        public static void Executar()
        {
            SemFilho semFilho = new SemFilho();
            Console.WriteLine(semFilho.ValorDaFortuna());

            FilhoRebelde filho = new FilhoRebelde();
            Console.WriteLine(filho.HonrarNomeFamilia());



        }
    }
}
