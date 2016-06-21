using ProgectTemplate.Business.Entity.Table;
using System.Data.Entity.ModelConfiguration;

namespace ProgectTemplate.Repository.EntityConfig.Table
{
    public class WUserMap : EntityTypeConfiguration<WUser>
    {
        public WUserMap()
        {
            // Primary Key
            this.HasKey(t => t.CodUser);

            // Properties
            this.Property(t => t.DsUserName)
                .HasMaxLength(50);

            this.Property(t => t.DsName)
                .HasMaxLength(128);

            this.Property(t => t.DsPassword)
                .HasMaxLength(64);

            this.Property(t => t.DsEmail)
                .HasMaxLength(128);

            this.Property(t => t.DsCelular)
                .HasMaxLength(24);

            this.Property(t => t.DsPhone)
                .HasMaxLength(24);

            this.Property(t => t.DsFax)
                .HasMaxLength(24);

            this.Property(t => t.DsCep)
                .HasMaxLength(10);

            this.Property(t => t.DsAddress)
                .HasMaxLength(128);

            this.Property(t => t.DsDistrict)
                .HasMaxLength(127);

            this.Property(t => t.DsCity)
                .HasMaxLength(32);

            this.Property(t => t.StUserActive)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.StAdministrator)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.CodUserType)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.StColumnist)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.StEnabled)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.DsCpf)
                .HasMaxLength(14);

            this.Property(t => t.DsIdentification)
                .HasMaxLength(32);

            this.Property(t => t.DsContact)
                .HasMaxLength(128);

            this.Property(t => t.DsZone)
                .HasMaxLength(64);

            this.Property(t => t.StNewsletter)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.StLoginType)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.StAbsent)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.DsPhoto)
                .HasMaxLength(255);

            this.Property(t => t.StAccountLocked)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.StAdministratorGlobal)
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("wUSER");
            this.Property(t => t.CodUser).HasColumnName("CodUser");
            this.Property(t => t.DsUserName).HasColumnName("DsUserName");
            this.Property(t => t.DsName).HasColumnName("DsName");
            this.Property(t => t.DsPassword).HasColumnName("DsPassword");
            this.Property(t => t.DsEmail).HasColumnName("DsEmail");
            this.Property(t => t.DsCelular).HasColumnName("DsCelular");
            this.Property(t => t.DsPhone).HasColumnName("DsPhone");
            this.Property(t => t.DsFax).HasColumnName("DsFax");
            this.Property(t => t.DsCep).HasColumnName("DsCEP");
            this.Property(t => t.DsAddress).HasColumnName("DsAddress");
            this.Property(t => t.DsDistrict).HasColumnName("DsDistrict");
            this.Property(t => t.DsCity).HasColumnName("DsCity");
            this.Property(t => t.StUserActive).HasColumnName("StUserActive");
            this.Property(t => t.StAdministrator).HasColumnName("StAdministrator");
            this.Property(t => t.CodUserType).HasColumnName("CodUserType");
            this.Property(t => t.StColumnist).HasColumnName("StColumnist");
            this.Property(t => t.CodCity).HasColumnName("CodCity");
            this.Property(t => t.StEnabled).HasColumnName("StEnabled");
            this.Property(t => t.DsCpf).HasColumnName("DsCPF");
            this.Property(t => t.DsIdentification).HasColumnName("DsIdentification");
            this.Property(t => t.DsContact).HasColumnName("DsContact");
            this.Property(t => t.CodState).HasColumnName("CodState");
            this.Property(t => t.DsZone).HasColumnName("DsZone");
            this.Property(t => t.StNewsletter).HasColumnName("StNewsletter");
            this.Property(t => t.CodUserUid).HasColumnName("CodUserUID");
            this.Property(t => t.CodUserSubstitution).HasColumnName("CodUserSubstitution");
            this.Property(t => t.StLoginType).HasColumnName("StLoginType");
            this.Property(t => t.StAbsent).HasColumnName("StAbsent");
            this.Property(t => t.CodUserCreate).HasColumnName("CodUserCreate");
            this.Property(t => t.DsPhoto).HasColumnName("DsPhoto");
            this.Property(t => t.DtLastPasswordChange).HasColumnName("DtLastPasswordChange");
            this.Property(t => t.NbLoginAttemptFailed).HasColumnName("NbLoginAttemptFailed");
            this.Property(t => t.StAccountLocked).HasColumnName("StAccountLocked");
            this.Property(t => t.StAdministratorGlobal).HasColumnName("StAdministratorGlobal");

            // Relationships
            // this.HasOptional(t => t.WCity)
            //     .WithMany(t => t.WUsers)
            //     .HasForeignKey(d => d.CodCity);
            // this.HasOptional(t => t.WUser2)
            //     .WithMany(t => t.WUser1)
            //     .HasForeignKey(d => d.CodUserSubstitution);

        }
    }
}
