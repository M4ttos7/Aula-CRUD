using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap07_Ex1
{
    class CadAluno 
    {
        public string NOME;
        public float[] nota = new float[4];

        public float CalcMedia()
        {
            byte i;
            float SOMA, MEDIA;
            SOMA = 0;

            for (i = 0; i <= 3; i++)
            {
                SOMA = SOMA + nota[i];
            }
                MEDIA = SOMA / 4;
                return MEDIA;
            }

        }
    }

