using Manager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Manager.Infra.Mappings
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .UseIdentityColumn()
                .HasColumnType("BIGINT");

            builder.Property(x => x.Name)
                .HasMaxLength(60)
                .IsRequired()
                .HasColumnType("VARCHAR(60)")
                .HasColumnName("name");

            builder.Property(x => x.Email)
                .HasMaxLength(180)
                .HasColumnType("VARCHAR(180)")
                .HasColumnName("email");

            builder.Property(x => x.Password)
                .HasMaxLength(30)
                .IsRequired()
                .HasColumnType("VARCHAR(30)")
                .HasColumnName("password");
        }
    }
}
