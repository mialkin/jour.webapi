﻿// <auto-generated />
using System;
using Jour.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Jour.Database.Migrations.Migrations
{
    [DbContext(typeof(JourContext))]
    partial class JourContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("GoalTag", b =>
                {
                    b.Property<int>("GoalsGoalId")
                        .HasColumnType("integer")
                        .HasColumnName("goals_goal_id");

                    b.Property<int>("TagsTagId")
                        .HasColumnType("integer")
                        .HasColumnName("tags_tag_id");

                    b.HasKey("GoalsGoalId", "TagsTagId")
                        .HasName("pk_goal_tag");

                    b.HasIndex("TagsTagId")
                        .HasDatabaseName("ix_goal_tag_tags_tag_id");

                    b.ToTable("goal_tag");
                });

            modelBuilder.Entity("Jour.Database.Dtos.Birthday", b =>
                {
                    b.Property<int>("BirthdayId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("birthday_id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("date")
                        .HasColumnName("date_of_birth");

                    b.Property<string>("FirstName")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("last_name");

                    b.HasKey("BirthdayId")
                        .HasName("pk_birthdays");

                    b.ToTable("birthdays");
                });

            modelBuilder.Entity("Jour.Database.Dtos.Exercise", b =>
                {
                    b.Property<int>("ExerciseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("exercise_id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<int?>("TrainingWorkoutId")
                        .HasColumnType("integer")
                        .HasColumnName("training_workout_id");

                    b.HasKey("ExerciseId")
                        .HasName("pk_exercises");

                    b.HasIndex("TrainingWorkoutId")
                        .HasDatabaseName("ix_exercises_training_workout_id");

                    b.ToTable("exercises");
                });

            modelBuilder.Entity("Jour.Database.Dtos.Goal", b =>
                {
                    b.Property<int>("GoalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("goal_id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("date")
                        .HasColumnName("date_created");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("title");

                    b.HasKey("GoalId")
                        .HasName("pk_goals");

                    b.ToTable("goals");
                });

            modelBuilder.Entity("Jour.Database.Dtos.Tag", b =>
                {
                    b.Property<int>("TagId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("tag_id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("title");

                    b.HasKey("TagId")
                        .HasName("pk_tags");

                    b.HasIndex("Title")
                        .IsUnique()
                        .HasDatabaseName("ix_tags_title");

                    b.ToTable("tags");
                });

            modelBuilder.Entity("Jour.Database.Dtos.Todo", b =>
                {
                    b.Property<int>("ToDoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("to_do_id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime?>("CompletedUtc")
                        .HasColumnType("date")
                        .HasColumnName("completed_utc");

                    b.Property<DateTime>("CreatedUtc")
                        .HasColumnType("date")
                        .HasColumnName("created_utc");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("title");

                    b.HasKey("ToDoId")
                        .HasName("pk_todos");

                    b.ToTable("todos");
                });

            modelBuilder.Entity("Jour.Database.Dtos.Training", b =>
                {
                    b.Property<int>("WorkoutId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("workout_id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("WorkoutDate")
                        .HasColumnType("date")
                        .HasColumnName("workout_date");

                    b.HasKey("WorkoutId")
                        .HasName("pk_training");

                    b.ToTable("training");
                });

            modelBuilder.Entity("GoalTag", b =>
                {
                    b.HasOne("Jour.Database.Dtos.Goal", null)
                        .WithMany()
                        .HasForeignKey("GoalsGoalId")
                        .HasConstraintName("fk_goal_tag_goals_goals_goal_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Jour.Database.Dtos.Tag", null)
                        .WithMany()
                        .HasForeignKey("TagsTagId")
                        .HasConstraintName("fk_goal_tag_tags_tags_tag_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Jour.Database.Dtos.Exercise", b =>
                {
                    b.HasOne("Jour.Database.Dtos.Training", null)
                        .WithMany("Exercises")
                        .HasForeignKey("TrainingWorkoutId")
                        .HasConstraintName("fk_exercises_training_training_workout_id");
                });

            modelBuilder.Entity("Jour.Database.Dtos.Training", b =>
                {
                    b.Navigation("Exercises");
                });
#pragma warning restore 612, 618
        }
    }
}
