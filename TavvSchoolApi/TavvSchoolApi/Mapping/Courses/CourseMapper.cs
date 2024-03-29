﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TavvSchoolApi.Entities;

namespace TavvSchoolApi.Mapping.Courses;

public class CourseMapper : IEntityTypeConfiguration<Course>
{
    public void Configure(EntityTypeBuilder<Course> builder)
    {

        builder.Property(c => c.Name)
            .HasMaxLength(50)
            .IsRequired();

        builder.HasOne(c => c.Group)
             .WithMany(g => g.Courses)
             .HasForeignKey(c => c.GroupId)
             .OnDelete(DeleteBehavior.Restrict);

    }
}
