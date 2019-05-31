//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace DB_Fancy
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.MyFavorites = new HashSet<MyFavorite>();
            this.OrderDetails = new HashSet<OrderDetail>();
            this.ProductEvaluations = new HashSet<ProductEvaluation>();
            this.ProductColors = new HashSet<ProductColor>();
            this.ProductPhotoes = new HashSet<ProductPhoto>();
            this.ProductSizes = new HashSet<ProductSize>();
            this.ProductStocks = new HashSet<ProductStock>();
            this.ProductWashings = new HashSet<ProductWashing>();
        }
    
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Desctiption { get; set; }
        public int CategorySID { get; set; }
        public int UnitPrice { get; set; }
        public Nullable<int> SupplierID { get; set; }
        public Nullable<System.DateTime> ProductInDate { get; set; }
        public Nullable<System.DateTime> ProductOutDate { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
    
        public virtual CategorySmall CategorySmall { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MyFavorite> MyFavorites { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductEvaluation> ProductEvaluations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductColor> ProductColors { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductPhoto> ProductPhotoes { get; set; }
        public virtual Supplier Supplier { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductSize> ProductSizes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductStock> ProductStocks { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductWashing> ProductWashings { get; set; }
    }
}
