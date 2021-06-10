﻿// <auto-generated />
using System;
using CC.Yi.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CC.Yi.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210609130329_jiftcc27")]
    partial class jiftcc27
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("CC.Yi.Model.action", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("action_name")
                        .HasColumnType("TEXT");

                    b.Property<string>("icon")
                        .HasColumnType("TEXT");

                    b.Property<int>("is_delete")
                        .HasColumnType("INTEGER");

                    b.Property<string>("router")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("action");
                });

            modelBuilder.Entity("CC.Yi.Model.agree", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("discussid")
                        .HasColumnType("INTEGER");

                    b.Property<int>("is_delete")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("userid")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.HasIndex("discussid");

                    b.HasIndex("userid");

                    b.ToTable("agree");
                });

            modelBuilder.Entity("CC.Yi.Model.banner", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("color")
                        .HasColumnType("TEXT");

                    b.Property<int>("is_delete")
                        .HasColumnType("INTEGER");

                    b.Property<string>("logo")
                        .HasColumnType("TEXT");

                    b.Property<string>("name")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("banner");
                });

            modelBuilder.Entity("CC.Yi.Model.collection", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("discussid")
                        .HasColumnType("INTEGER");

                    b.Property<int>("is_delete")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("time")
                        .HasColumnType("TEXT");

                    b.Property<int?>("userid")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.HasIndex("discussid");

                    b.HasIndex("userid");

                    b.ToTable("collection");
                });

            modelBuilder.Entity("CC.Yi.Model.comment", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("content")
                        .HasColumnType("TEXT");

                    b.Property<int?>("discussid")
                        .HasColumnType("INTEGER");

                    b.Property<int>("is_delete")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("time")
                        .HasColumnType("TEXT");

                    b.Property<int?>("userid")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.HasIndex("discussid");

                    b.HasIndex("userid");

                    b.ToTable("comment");
                });

            modelBuilder.Entity("CC.Yi.Model.discuss", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("agree_num")
                        .HasColumnType("INTEGER");

                    b.Property<string>("color")
                        .HasColumnType("TEXT");

                    b.Property<string>("content")
                        .HasColumnType("TEXT");

                    b.Property<int>("encryption")
                        .HasColumnType("INTEGER");

                    b.Property<string>("introduction")
                        .HasColumnType("TEXT");

                    b.Property<int>("is_anonymous")
                        .HasColumnType("INTEGER");

                    b.Property<int>("is_delete")
                        .HasColumnType("INTEGER");

                    b.Property<int>("is_top")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("plateid")
                        .HasColumnType("INTEGER");

                    b.Property<int>("see_num")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("time")
                        .HasColumnType("TEXT");

                    b.Property<string>("title")
                        .HasColumnType("TEXT");

                    b.Property<string>("type")
                        .HasColumnType("TEXT");

                    b.Property<int?>("userid")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.HasIndex("plateid");

                    b.HasIndex("userid");

                    b.ToTable("discuss");
                });

            modelBuilder.Entity("CC.Yi.Model.label", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("color")
                        .HasColumnType("TEXT");

                    b.Property<string>("color_bg")
                        .HasColumnType("TEXT");

                    b.Property<int>("is_delete")
                        .HasColumnType("INTEGER");

                    b.Property<string>("name")
                        .HasColumnType("TEXT");

                    b.Property<int?>("userid")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.HasIndex("userid");

                    b.ToTable("label");
                });

            modelBuilder.Entity("CC.Yi.Model.level", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("experience")
                        .HasColumnType("INTEGER");

                    b.Property<int>("is_delete")
                        .HasColumnType("INTEGER");

                    b.Property<int>("max_char")
                        .HasColumnType("INTEGER");

                    b.Property<string>("name")
                        .HasColumnType("TEXT");

                    b.Property<int>("num")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.ToTable("level");
                });

            modelBuilder.Entity("CC.Yi.Model.plate", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("introduction")
                        .HasColumnType("TEXT");

                    b.Property<int>("is_delete")
                        .HasColumnType("INTEGER");

                    b.Property<string>("logo")
                        .HasColumnType("TEXT");

                    b.Property<string>("name")
                        .HasColumnType("TEXT");

                    b.Property<int?>("userid")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.HasIndex("userid");

                    b.ToTable("plate");
                });

            modelBuilder.Entity("CC.Yi.Model.role", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("is_delete")
                        .HasColumnType("INTEGER");

                    b.Property<string>("role_name")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("role");
                });

            modelBuilder.Entity("CC.Yi.Model.user", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("email")
                        .HasColumnType("TEXT");

                    b.Property<string>("icon")
                        .HasColumnType("TEXT");

                    b.Property<string>("ip")
                        .HasColumnType("TEXT");

                    b.Property<int>("is_delete")
                        .HasColumnType("INTEGER");

                    b.Property<string>("nick")
                        .HasColumnType("TEXT");

                    b.Property<string>("openid")
                        .HasColumnType("TEXT");

                    b.Property<string>("password")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("time")
                        .HasColumnType("TEXT");

                    b.Property<int?>("user_extraid")
                        .HasColumnType("INTEGER");

                    b.Property<string>("username")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.HasIndex("user_extraid");

                    b.ToTable("user");
                });

            modelBuilder.Entity("CC.Yi.Model.user_extra", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("experience")
                        .HasColumnType("INTEGER");

                    b.Property<string>("introduction")
                        .HasColumnType("TEXT");

                    b.Property<int>("is_delete")
                        .HasColumnType("INTEGER");

                    b.Property<int>("level")
                        .HasColumnType("INTEGER");

                    b.Property<int>("num_release")
                        .HasColumnType("INTEGER");

                    b.Property<int>("num_reply")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.ToTable("user_extra");
                });

            modelBuilder.Entity("CC.Yi.Model.version", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("color")
                        .HasColumnType("TEXT");

                    b.Property<string>("context")
                        .HasColumnType("TEXT");

                    b.Property<int>("is_delete")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("time")
                        .HasColumnType("TEXT");

                    b.Property<string>("ver")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("version");
                });

            modelBuilder.Entity("actionrole", b =>
                {
                    b.Property<int>("actionsid")
                        .HasColumnType("INTEGER");

                    b.Property<int>("rolesid")
                        .HasColumnType("INTEGER");

                    b.HasKey("actionsid", "rolesid");

                    b.HasIndex("rolesid");

                    b.ToTable("actionrole");
                });

            modelBuilder.Entity("actionuser", b =>
                {
                    b.Property<int>("actionsid")
                        .HasColumnType("INTEGER");

                    b.Property<int>("usersid")
                        .HasColumnType("INTEGER");

                    b.HasKey("actionsid", "usersid");

                    b.HasIndex("usersid");

                    b.ToTable("actionuser");
                });

            modelBuilder.Entity("discusslabel", b =>
                {
                    b.Property<int>("discussesid")
                        .HasColumnType("INTEGER");

                    b.Property<int>("labelsid")
                        .HasColumnType("INTEGER");

                    b.HasKey("discussesid", "labelsid");

                    b.HasIndex("labelsid");

                    b.ToTable("discusslabel");
                });

            modelBuilder.Entity("roleuser", b =>
                {
                    b.Property<int>("rolesid")
                        .HasColumnType("INTEGER");

                    b.Property<int>("usersid")
                        .HasColumnType("INTEGER");

                    b.HasKey("rolesid", "usersid");

                    b.HasIndex("usersid");

                    b.ToTable("roleuser");
                });

            modelBuilder.Entity("CC.Yi.Model.agree", b =>
                {
                    b.HasOne("CC.Yi.Model.discuss", "discuss")
                        .WithMany()
                        .HasForeignKey("discussid");

                    b.HasOne("CC.Yi.Model.user", "user")
                        .WithMany()
                        .HasForeignKey("userid");

                    b.Navigation("discuss");

                    b.Navigation("user");
                });

            modelBuilder.Entity("CC.Yi.Model.collection", b =>
                {
                    b.HasOne("CC.Yi.Model.discuss", "discuss")
                        .WithMany()
                        .HasForeignKey("discussid");

                    b.HasOne("CC.Yi.Model.user", "user")
                        .WithMany()
                        .HasForeignKey("userid");

                    b.Navigation("discuss");

                    b.Navigation("user");
                });

            modelBuilder.Entity("CC.Yi.Model.comment", b =>
                {
                    b.HasOne("CC.Yi.Model.discuss", "discuss")
                        .WithMany("comments")
                        .HasForeignKey("discussid");

                    b.HasOne("CC.Yi.Model.user", "user")
                        .WithMany("comments")
                        .HasForeignKey("userid");

                    b.Navigation("discuss");

                    b.Navigation("user");
                });

            modelBuilder.Entity("CC.Yi.Model.discuss", b =>
                {
                    b.HasOne("CC.Yi.Model.plate", "plate")
                        .WithMany("discusses")
                        .HasForeignKey("plateid");

                    b.HasOne("CC.Yi.Model.user", "user")
                        .WithMany("discusses")
                        .HasForeignKey("userid");

                    b.Navigation("plate");

                    b.Navigation("user");
                });

            modelBuilder.Entity("CC.Yi.Model.label", b =>
                {
                    b.HasOne("CC.Yi.Model.user", "user")
                        .WithMany("labels")
                        .HasForeignKey("userid");

                    b.Navigation("user");
                });

            modelBuilder.Entity("CC.Yi.Model.plate", b =>
                {
                    b.HasOne("CC.Yi.Model.user", null)
                        .WithMany("plates")
                        .HasForeignKey("userid");
                });

            modelBuilder.Entity("CC.Yi.Model.user", b =>
                {
                    b.HasOne("CC.Yi.Model.user_extra", "user_extra")
                        .WithMany()
                        .HasForeignKey("user_extraid");

                    b.Navigation("user_extra");
                });

            modelBuilder.Entity("actionrole", b =>
                {
                    b.HasOne("CC.Yi.Model.action", null)
                        .WithMany()
                        .HasForeignKey("actionsid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CC.Yi.Model.role", null)
                        .WithMany()
                        .HasForeignKey("rolesid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("actionuser", b =>
                {
                    b.HasOne("CC.Yi.Model.action", null)
                        .WithMany()
                        .HasForeignKey("actionsid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CC.Yi.Model.user", null)
                        .WithMany()
                        .HasForeignKey("usersid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("discusslabel", b =>
                {
                    b.HasOne("CC.Yi.Model.discuss", null)
                        .WithMany()
                        .HasForeignKey("discussesid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CC.Yi.Model.label", null)
                        .WithMany()
                        .HasForeignKey("labelsid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("roleuser", b =>
                {
                    b.HasOne("CC.Yi.Model.role", null)
                        .WithMany()
                        .HasForeignKey("rolesid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CC.Yi.Model.user", null)
                        .WithMany()
                        .HasForeignKey("usersid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CC.Yi.Model.discuss", b =>
                {
                    b.Navigation("comments");
                });

            modelBuilder.Entity("CC.Yi.Model.plate", b =>
                {
                    b.Navigation("discusses");
                });

            modelBuilder.Entity("CC.Yi.Model.user", b =>
                {
                    b.Navigation("comments");

                    b.Navigation("discusses");

                    b.Navigation("labels");

                    b.Navigation("plates");
                });
#pragma warning restore 612, 618
        }
    }
}
