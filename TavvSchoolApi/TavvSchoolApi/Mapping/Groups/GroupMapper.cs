using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TavvSchoolApi.Entities;

namespace TavvSchoolApi.Mapping.Groups;

public class GroupMapper : IEntityTypeConfiguration<Group>
{
    public void Configure(EntityTypeBuilder<Group> builder)
    {


        builder.Property(g => g.Name)
            .HasMaxLength(50);

    }
}
