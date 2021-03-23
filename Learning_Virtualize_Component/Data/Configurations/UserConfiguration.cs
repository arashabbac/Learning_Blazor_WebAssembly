namespace Data.Configurations
{
    public class UserConfiguration :
        Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<Models.User>
    {
        public void Configure
            (Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Models.User> builder)
        {
            builder.Property(c => c.Type)
                .IsRequired();

            builder.Property(c => c.FullName)
                .HasMaxLength(Models.Constant.Length.FULL_NAME)
                .IsRequired();

            builder.Property(c => c.Username)
                .HasMaxLength(Models.Constant.Length.USERNAME)
                .IsUnicode(false)
                .IsRequired();

            builder.Property(c => c.Password)
                .HasMaxLength(Models.Constant.Length.PASSWORD)
                .IsUnicode(false)
                .IsRequired();

            builder.Property(c => c.NationalCode)
                .IsUnicode(false)
                .HasMaxLength(Models.Constant.Length.NATIONAL_CODE);

            builder.Property(c => c.EmailAddress)
                .IsUnicode(false)
                .HasMaxLength(Models.Constant.Length.EMAIL_ADDRESS);

            builder.Property(c => c.CellPhoneNumber)
                .IsUnicode(false)
                .HasMaxLength(Models.Constant.Length.MIN_CELL_PHONE_NUMBER);

            builder.HasIndex(c => c.Username)
                .IsUnique(false)
                .IsUnique();
        }
    }
}
