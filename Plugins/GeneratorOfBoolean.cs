﻿using PluginInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plugins
{
     class GeneratorOfBoolean : IGenerator
     {
          private Random random = new Random((int)DateTime.Now.Ticks);

          public object generateValue()
          {
               if (random.Next() % 2 == 0)
               {
                    return (Boolean)false;
               }
               return (Boolean)true;
          }

          public Type GetValueType()
          {
               return typeof(Boolean);
          }
           
     }
}