//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Studio1B22.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Units
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int StudentId { get; set; }
    
        public virtual Students Students { get; set; }
    }
}
