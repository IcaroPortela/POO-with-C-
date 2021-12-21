using System;
using System.Collections.Generic;

namespace Caixa {
    
public class Cliente {
        public string Nome {get; set;}
}
public class CartaoCredito{
        public string Numero {get; set;}
        public string DatadeValidade { get; set;}
        
        public Cliente cliente {get; set;}
}
}