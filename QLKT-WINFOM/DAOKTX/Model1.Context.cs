//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAOKTX
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Desso30_NGUYENCHIMANHEntities : DbContext
    {
        public Desso30_NGUYENCHIMANHEntities()
            : base("name=Desso30_NGUYENCHIMANHEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<chitietphongkt> chitietphongkts { get; set; }
        public virtual DbSet<Hoadonphong> Hoadonphongs { get; set; }
        public virtual DbSet<Hoadonsv> Hoadonsvs { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<Phongkt> Phongkts { get; set; }
        public virtual DbSet<SINHVIENRA> SINHVIENRAs { get; set; }
        public virtual DbSet<SINHVIENVAO> SINHVIENVAOs { get; set; }
        public virtual DbSet<viewdanhsachphong> viewdanhsachphongs { get; set; }
        public virtual DbSet<viewdanhsachsvvao> viewdanhsachsvvaos { get; set; }
    
        [DbFunction("Desso30_NGUYENCHIMANHEntities", "infopsv_f3")]
        public virtual IQueryable<infopsv_f3_Result> infopsv_f3(string masv)
        {
            var masvParameter = masv != null ?
                new ObjectParameter("masv", masv) :
                new ObjectParameter("masv", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<infopsv_f3_Result>("[Desso30_NGUYENCHIMANHEntities].[infopsv_f3](@masv)", masvParameter);
        }
    
        [DbFunction("Desso30_NGUYENCHIMANHEntities", "inforsv_f4")]
        public virtual IQueryable<inforsv_f4_Result> inforsv_f4(Nullable<System.DateTime> date)
        {
            var dateParameter = date.HasValue ?
                new ObjectParameter("date", date) :
                new ObjectParameter("date", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<inforsv_f4_Result>("[Desso30_NGUYENCHIMANHEntities].[inforsv_f4](@date)", dateParameter);
        }
    
        [DbFunction("Desso30_NGUYENCHIMANHEntities", "sumtp_f1")]
        public virtual IQueryable<sumtp_f1_Result> sumtp_f1(string masv)
        {
            var masvParameter = masv != null ?
                new ObjectParameter("masv", masv) :
                new ObjectParameter("masv", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<sumtp_f1_Result>("[Desso30_NGUYENCHIMANHEntities].[sumtp_f1](@masv)", masvParameter);
        }
    
        public virtual int del_pr5(string map)
        {
            var mapParameter = map != null ?
                new ObjectParameter("map", map) :
                new ObjectParameter("map", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("del_pr5", mapParameter);
        }
    
        public virtual int delsv_pr6(string msvr)
        {
            var msvrParameter = msvr != null ?
                new ObjectParameter("msvr", msvr) :
                new ObjectParameter("msvr", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("delsv_pr6", msvrParameter);
        }
    
        public virtual ObjectResult<selectsv_pr7_Result> selectsv_pr7(string map)
        {
            var mapParameter = map != null ?
                new ObjectParameter("map", map) :
                new ObjectParameter("map", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<selectsv_pr7_Result>("selectsv_pr7", mapParameter);
        }
    
        public virtual ObjectResult<selectsv_pr8_Result> selectsv_pr8(string malop, string mahd)
        {
            var malopParameter = malop != null ?
                new ObjectParameter("malop", malop) :
                new ObjectParameter("malop", typeof(string));
    
            var mahdParameter = mahd != null ?
                new ObjectParameter("mahd", mahd) :
                new ObjectParameter("mahd", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<selectsv_pr8_Result>("selectsv_pr8", malopParameter, mahdParameter);
        }
    
        public virtual int themhd_pr2(string mahd, string msv, Nullable<int> tp, Nullable<int> td, Nullable<int> tt)
        {
            var mahdParameter = mahd != null ?
                new ObjectParameter("mahd", mahd) :
                new ObjectParameter("mahd", typeof(string));
    
            var msvParameter = msv != null ?
                new ObjectParameter("msv", msv) :
                new ObjectParameter("msv", typeof(string));
    
            var tpParameter = tp.HasValue ?
                new ObjectParameter("tp", tp) :
                new ObjectParameter("tp", typeof(int));
    
            var tdParameter = td.HasValue ?
                new ObjectParameter("td", td) :
                new ObjectParameter("td", typeof(int));
    
            var ttParameter = tt.HasValue ?
                new ObjectParameter("tt", tt) :
                new ObjectParameter("tt", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("themhd_pr2", mahdParameter, msvParameter, tpParameter, tdParameter, ttParameter);
        }
    
        public virtual int themphong_pr1(string maphong, string day, string vt, string lp, string tt)
        {
            var maphongParameter = maphong != null ?
                new ObjectParameter("maphong", maphong) :
                new ObjectParameter("maphong", typeof(string));
    
            var dayParameter = day != null ?
                new ObjectParameter("day", day) :
                new ObjectParameter("day", typeof(string));
    
            var vtParameter = vt != null ?
                new ObjectParameter("vt", vt) :
                new ObjectParameter("vt", typeof(string));
    
            var lpParameter = lp != null ?
                new ObjectParameter("lp", lp) :
                new ObjectParameter("lp", typeof(string));
    
            var ttParameter = tt != null ?
                new ObjectParameter("tt", tt) :
                new ObjectParameter("tt", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("themphong_pr1", maphongParameter, dayParameter, vtParameter, lpParameter, ttParameter);
        }
    
        public virtual int thongke_pr9()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("thongke_pr9");
        }
    
        public virtual int trungbinh_pr10()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("trungbinh_pr10");
        }
    }
}
