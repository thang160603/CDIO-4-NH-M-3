namespace CDIO_4._1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class CreatedDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.nhap_kho",
                c => new
                {
                    ma_nhap_kho = c.Int(nullable: false, identity: true),
                    ma_san_pham = c.Int(nullable: false),
                    ma_nha_cung_cap = c.Int(nullable: false),
                    so_luong = c.Int(nullable: false),
                    ngay_nhap = c.DateTime(nullable: false),
                    NhaCungCap_ma_nhap_kho = c.Int(),
                })
                .PrimaryKey(t => t.ma_nhap_kho)
                .ForeignKey("dbo.nha_cung_cap", t => t.NhaCungCap_ma_nhap_kho)
                .ForeignKey("dbo.san_pham", t => t.ma_san_pham)
                .Index(t => t.ma_san_pham)
                .Index(t => t.NhaCungCap_ma_nhap_kho);

            CreateTable(
                "dbo.chi_tiet_hoa_don_nhap",
                c => new
                {
                    ma_chi_tiet_nhap = c.Int(nullable: false, identity: true),
                    ma_nhap_kho = c.Int(nullable: false),
                    ma_san_pham = c.Int(nullable: false),
                    so_luong = c.Int(nullable: false),
                    thanh_tien = c.Decimal(nullable: false, precision: 18, scale: 2),
                    don_gia = c.Decimal(nullable: false, precision: 18, scale: 2),
                })
                .PrimaryKey(t => t.ma_chi_tiet_nhap)
                .ForeignKey("dbo.nhap_kho", t => t.ma_nhap_kho)
                .ForeignKey("dbo.san_pham", t => t.ma_san_pham)
                .Index(t => t.ma_nhap_kho)
                .Index(t => t.ma_san_pham);

            CreateTable(
                "dbo.nha_cung_cap",
                c => new
                {
                    ma_nha_cung_cap = c.Int(nullable: false, identity: true),
                    ten_nha_cung_cap = c.String(),
                    dia_chi = c.String(),
                    so_dien_thoai = c.String(),
                })
                .PrimaryKey(t => t.ma_nha_cung_cap);

            CreateTable(
                "dbo.san_pham",
                c => new
                {
                    ma_san_pham = c.Int(nullable: false, identity: true),
                    ten_san_pham = c.String(),
                    mo_ta = c.String(),
                    gia = c.Decimal(nullable: false, precision: 18, scale: 2),
                    ma_danh_muc = c.Int(nullable: false),
                    so_luong_ton = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.ma_san_pham)
                .ForeignKey("dbo.danh_muc", t => t.ma_danh_muc, cascadeDelete: true)
                .Index(t => t.ma_danh_muc);

            CreateTable(
                "dbo.chi_tiet_hoa_don",
                c => new
                {
                    ma_chi_tiet_hoa_don = c.Int(nullable: false, identity: true),
                    ma_don_hang = c.Int(nullable: false),
                    ma_san_pham = c.Int(nullable: false),
                    so_luong = c.Int(nullable: false),
                    don_gia = c.Decimal(nullable: false, precision: 18, scale: 2),
                    thanh_tien = c.Decimal(nullable: false, precision: 18, scale: 2),
                })
                .PrimaryKey(t => t.ma_chi_tiet_hoa_don)
                .ForeignKey("dbo.don_hang", t => t.ma_don_hang, cascadeDelete: true)
                .ForeignKey("dbo.san_pham", t => t.ma_san_pham)
                .Index(t => t.ma_don_hang)
                .Index(t => t.ma_san_pham);

            CreateTable(
                "dbo.don_hang",
                c => new
                {
                    ma_don_hang = c.Int(nullable: false, identity: true),
                    ma_nguoi_dung = c.Int(nullable: false),
                    ngay_dat = c.DateTime(nullable: false),
                    tong_tien = c.Decimal(nullable: false, precision: 18, scale: 2),
                    trang_thai = c.String(),
                    ma_van_chuyen = c.Int(nullable: false),
                    Phuong_thuc_thanh_toan = c.String(),
                    ma_danh_gia = c.Int(nullable: false),
                    ma_voucher = c.Int(nullable: false),
                    Voucher_ma_voucher = c.Int(),
                })
                .PrimaryKey(t => t.ma_don_hang)
                .ForeignKey("dbo.danh_gia", t => t.ma_danh_gia, cascadeDelete: true)
                .ForeignKey("dbo.nguoi_dung", t => t.ma_nguoi_dung, cascadeDelete: true)
                .ForeignKey("dbo.van_chuyen", t => t.ma_van_chuyen, cascadeDelete: true)
                .ForeignKey("dbo.voucher", t => t.Voucher_ma_voucher)
                .Index(t => t.ma_nguoi_dung)
                .Index(t => t.ma_van_chuyen)
                .Index(t => t.ma_danh_gia)
                .Index(t => t.Voucher_ma_voucher);

            CreateTable(
                "dbo.danh_gia",
                c => new
                {
                    ma_danh_gia = c.Int(nullable: false, identity: true),
                    ma_san_pham = c.Int(nullable: false),
                    ma_nguoi_dung = c.Int(nullable: false),
                    noi_dung = c.String(),
                    diem = c.Int(nullable: false),
                    ngay_danh_gia = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.ma_danh_gia);

            CreateTable(
                "dbo.nguoi_dung",
                c => new
                {
                    ma_nguoi_dung = c.Int(nullable: false, identity: true),
                    ten_dang_nhap = c.String(),
                    mat_khau = c.String(),
                    email = c.String(),
                })
                .PrimaryKey(t => t.ma_nguoi_dung);

            CreateTable(
                "dbo.vai_tro_nguoi_dung",
                c => new
                {
                    ma_vai_tro_nguoi_dung = c.Int(nullable: false, identity: true),
                    ma_nguoi_dung = c.Int(nullable: false),
                    ma_vai_tro = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.ma_vai_tro_nguoi_dung)
                .ForeignKey("dbo.vai_tro", t => t.ma_vai_tro, cascadeDelete: true)
                .ForeignKey("dbo.nguoi_dung", t => t.ma_nguoi_dung, cascadeDelete: true)
                .Index(t => t.ma_nguoi_dung)
                .Index(t => t.ma_vai_tro);

            CreateTable(
                "dbo.vai_tro",
                c => new
                {
                    ma_vai_tro = c.Int(nullable: false, identity: true),
                    ten_vai_tro = c.String(),
                })
                .PrimaryKey(t => t.ma_vai_tro);

            CreateTable(
                "dbo.van_chuyen",
                c => new
                {
                    ma_van_chuyen = c.Int(nullable: false, identity: true),
                    ten_van_chuyen = c.String(),
                    phi_van_chuyen = c.Decimal(nullable: false, precision: 18, scale: 2),
                })
                .PrimaryKey(t => t.ma_van_chuyen);

            CreateTable(
                "dbo.voucher",
                c => new
                {
                    ma_voucher = c.Int(nullable: false, identity: true),
                    ma_nguoi_dung = c.Int(nullable: false),
                    ma_don_hang = c.Int(nullable: false),
                    giam_gia = c.Decimal(nullable: false, precision: 18, scale: 2),
                    ngay_bat_dau = c.DateTime(nullable: false),
                    ngay_ket_thuc = c.DateTime(nullable: false),
                    trang_thai = c.String(),
                })
                .PrimaryKey(t => t.ma_voucher);

            CreateTable(
                "dbo.danh_muc",
                c => new
                {
                    ma_danh_muc = c.Int(nullable: false, identity: true),
                    ten_danh_muc = c.String(),
                    mo_ta = c.String(),
                })
                .PrimaryKey(t => t.ma_danh_muc);
        }

        public override void Down()
        {
            // Tương tự như Up, thực hiện xóa khóa ngoại và chỉ số trước khi xóa bảng
            DropForeignKey("dbo.chi_tiet_hoa_don", "ma_san_pham", "dbo.san_pham");
            DropForeignKey("dbo.chi_tiet_hoa_don", "ma_don_hang", "dbo.don_hang");
            DropForeignKey("dbo.don_hang", "Voucher_ma_voucher", "dbo.voucher");
            DropForeignKey("dbo.don_hang", "ma_van_chuyen", "dbo.van_chuyen");
            DropForeignKey("dbo.vai_tro_nguoi_dung", "ma_vai_tro", "dbo.vai_tro");
            DropForeignKey("dbo.vai_tro_nguoi_dung", "ma_nguoi_dung", "dbo.nguoi_dung");
            DropForeignKey("dbo.don_hang", "ma_nguoi_dung", "dbo.nguoi_dung");
            DropForeignKey("dbo.don_hang", "ma_danh_gia", "dbo.danh_gia");
            DropForeignKey("dbo.chi_tiet_hoa_don_nhap", "ma_san_pham", "dbo.san_pham");
            DropForeignKey("dbo.nhap_kho", "ma_san_pham", "dbo.san_pham");
            DropForeignKey("dbo.san_pham", "ma_danh_muc", "dbo.danh_muc");
            DropForeignKey("dbo.chi_tiet_hoa_don_nhap", "ma_nhap_kho", "dbo.nhap_kho");
            DropForeignKey("dbo.nhap_kho", "NhaCungCap_ma_nhap_kho", "dbo.nha_cung_cap");
            DropIndex("dbo.vai_tro_nguoi_dung", new[] { "ma_vai_tro" });
            DropIndex("dbo.vai_tro_nguoi_dung", new[] { "ma_nguoi_dung" });
            DropIndex("dbo.don_hang", new[] { "Voucher_ma_voucher" });
            DropIndex("dbo.don_hang", new[] { "ma_danh_gia" });
            DropIndex("dbo.don_hang", new[] { "ma_van_chuyen" });
            DropIndex("dbo.don_hang", new[] { "ma_nguoi_dung" });
            DropIndex("dbo.chi_tiet_hoa_don", new[] { "ma_san_pham" });
            DropIndex("dbo.chi_tiet_hoa_don", new[] { "ma_don_hang" });
            DropIndex("dbo.san_pham", new[] { "ma_danh_muc" });
            DropIndex("dbo.chi_tiet_hoa_don_nhap", new[] { "ma_san_pham" });
            DropIndex("dbo.chi_tiet_hoa_don_nhap", new[] { "ma_nhap_kho" });
            DropIndex("dbo.nhap_kho", new[] { "NhaCungCap_ma_nhap_kho" });
            DropIndex("dbo.nhap_kho", new[] { "ma_san_pham" });
            DropTable("dbo.danh_muc");
            DropTable("dbo.voucher");
            DropTable("dbo.van_chuyen");
            DropTable("dbo.vai_tro");
            DropTable("dbo.vai_tro_nguoi_dung");
            DropTable("dbo.nguoi_dung");
            DropTable("dbo.danh_gia");
            DropTable("dbo.don_hang");
            DropTable("dbo.chi_tiet_hoa_don");
            DropTable("dbo.san_pham");
            DropTable("dbo.nha_cung_cap");
            DropTable("dbo.chi_tiet_hoa_don_nhap");
            DropTable("dbo.nhap_kho");
        }
    }
}
