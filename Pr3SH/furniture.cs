//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pr3SH
{
    using System;
    using System.Collections.Generic;
    
    public partial class furniture
    {
        public int id { get; set; }
        public string name { get; set; }
        public string material { get; set; }
        public string style { get; set; }
        public Nullable<int> count { get; set; }
        public Nullable<int> idType { get; set; }
    
        public virtual typeF typeF { get; set; }
    }
}
