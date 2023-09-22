﻿using System;
using System.Collections;
using System.Text;

namespace CursoCSharp.Colecoes {
    class ColecoesArrayList {
        public static void Executar() {
            var arrayList = new ArrayList {
                "Palavra",
                3,
                3.14,
                true,
                'k'
            };

            arrayList.Add(34.99);

            foreach(object item in arrayList) {
                Console.WriteLine("{0} => {1}", item, item.GetType());
            }
        }
    }
}