using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using CDIO_4._1.Models.EF;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace CDIO_4._1.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }
        public DbSet<ChiTietHoaDon>ChiTietHoaDons { get; set; }
        public DbSet<ChiTietHoaDonNhap>ChiTietHoaDonNhaps { get; set; }
        public DbSet<DanhGia>DanhGias { get; set; }
        public DbSet<DanhMuc>DanhMucs { get; set; }
        public DbSet<DonHang>DonHangs { get; set; }
        public DbSet<NguoiDung>NguoiDungs { get; set; }
        public DbSet<NhaCungCap>NhaCungCaps { get; set; }
        public DbSet<NhapKho>NhapKhos { get; set; }
        public DbSet<SanPham>SanPhams { get; set; }
        public DbSet<VanChuyen>VanChuyens { get; set; }
        public DbSet<Voucher>Vouchers { get; set; }
        public DbSet<VaiTroNguoiDung>VaiTroNguoiDungs { get; set; }
        public DbSet<VaiTro>VaiTros { get; set; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}