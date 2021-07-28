﻿// <auto-generated />
using System;
using CC.Yi.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CC.Yi.Model.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210719083717_jiftcc42")]
    partial class jiftcc42
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.7");

            modelBuilder.Entity("CC.Yi.Model.action", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("action_name")
                        .HasColumnType("longtext");

                    b.Property<string>("icon")
                        .HasColumnType("longtext");

                    b.Property<int>("is_delete")
                        .HasColumnType("int");

                    b.Property<string>("router")
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.ToTable("action");
                });

            modelBuilder.Entity("CC.Yi.Model.agree", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("discussid")
                        .HasColumnType("int");

                    b.Property<int>("is_delete")
                        .HasColumnType("int");

                    b.Property<int?>("userid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("discussid");

                    b.HasIndex("userid");

                    b.ToTable("agree");
                });

            modelBuilder.Entity("CC.Yi.Model.article", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("articleid")
                        .HasColumnType("int");

                    b.Property<string>("content")
                        .HasColumnType("longtext");

                    b.Property<int?>("discussid")
                        .HasColumnType("int");

                    b.Property<int>("is_delete")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.HasIndex("articleid");

                    b.HasIndex("discussid");

                    b.ToTable("article");
                });

            modelBuilder.Entity("CC.Yi.Model.banner", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("color")
                        .HasColumnType("longtext");

                    b.Property<int>("is_delete")
                        .HasColumnType("int");

                    b.Property<string>("logo")
                        .HasColumnType("longtext");

                    b.Property<string>("name")
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.ToTable("banner");
                });

            modelBuilder.Entity("CC.Yi.Model.collection", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("discussid")
                        .HasColumnType("int");

                    b.Property<int>("is_delete")
                        .HasColumnType("int");

                    b.Property<DateTime>("time")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("userid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("discussid");

                    b.HasIndex("userid");

                    b.ToTable("collection");
                });

            modelBuilder.Entity("CC.Yi.Model.comment", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("content")
                        .HasColumnType("longtext");

                    b.Property<int?>("discussid")
                        .HasColumnType("int");

                    b.Property<int>("is_delete")
                        .HasColumnType("int");

                    b.Property<DateTime?>("time")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("userid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("discussid");

                    b.HasIndex("userid");

                    b.ToTable("comment");
                });

            modelBuilder.Entity("CC.Yi.Model.discuss", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("agree_num")
                        .HasColumnType("int");

                    b.Property<string>("color")
                        .HasColumnType("longtext");

                    b.Property<string>("content")
                        .HasColumnType("longtext");

                    b.Property<string>("introduction")
                        .HasColumnType("longtext");

                    b.Property<int>("is_anonymous")
                        .HasColumnType("int");

                    b.Property<int>("is_delete")
                        .HasColumnType("int");

                    b.Property<int>("is_encryption")
                        .HasColumnType("int");

                    b.Property<int>("is_top")
                        .HasColumnType("int");

                    b.Property<int?>("plateid")
                        .HasColumnType("int");

                    b.Property<int>("see_num")
                        .HasColumnType("int");

                    b.Property<DateTime?>("time")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("title")
                        .HasColumnType("longtext");

                    b.Property<string>("type")
                        .HasColumnType("longtext");

                    b.Property<int?>("userid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("plateid");

                    b.HasIndex("userid");

                    b.ToTable("discuss");
                });

            modelBuilder.Entity("CC.Yi.Model.friend", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("is_agree")
                        .HasColumnType("int");

                    b.Property<int>("is_delete")
                        .HasColumnType("int");

                    b.Property<DateTime?>("time")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("user1id")
                        .HasColumnType("int");

                    b.Property<int?>("user2id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("user1id");

                    b.HasIndex("user2id");

                    b.ToTable("friend");
                });

            modelBuilder.Entity("CC.Yi.Model.label", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("color")
                        .HasColumnType("longtext");

                    b.Property<string>("color_bg")
                        .HasColumnType("longtext");

                    b.Property<int>("is_delete")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .HasColumnType("longtext");

                    b.Property<int?>("userid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("userid");

                    b.ToTable("label");
                });

            modelBuilder.Entity("CC.Yi.Model.level", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("experience")
                        .HasColumnType("int");

                    b.Property<int>("is_delete")
                        .HasColumnType("int");

                    b.Property<int>("max_char")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .HasColumnType("longtext");

                    b.Property<int>("num")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("level");
                });

            modelBuilder.Entity("CC.Yi.Model.mytype", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("is_delete")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.ToTable("mytype");
                });

            modelBuilder.Entity("CC.Yi.Model.plate", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("introduction")
                        .HasColumnType("longtext");

                    b.Property<int>("is_delete")
                        .HasColumnType("int");

                    b.Property<string>("logo")
                        .HasColumnType("longtext");

                    b.Property<string>("name")
                        .HasColumnType("longtext");

                    b.Property<int?>("userid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("userid");

                    b.ToTable("plate");
                });

            modelBuilder.Entity("CC.Yi.Model.prop", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("color")
                        .HasColumnType("longtext");

                    b.Property<string>("introduction")
                        .HasColumnType("longtext");

                    b.Property<int>("is_delete")
                        .HasColumnType("int");

                    b.Property<string>("logo")
                        .HasColumnType("longtext");

                    b.Property<string>("name")
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.ToTable("prop");
                });

            modelBuilder.Entity("CC.Yi.Model.record", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("describe")
                        .HasColumnType("longtext");

                    b.Property<int?>("discussid")
                        .HasColumnType("int");

                    b.Property<int>("is_delete")
                        .HasColumnType("int");

                    b.Property<DateTime?>("time")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("userid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("discussid");

                    b.HasIndex("userid");

                    b.ToTable("record");
                });

            modelBuilder.Entity("CC.Yi.Model.role", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("is_delete")
                        .HasColumnType("int");

                    b.Property<string>("role_name")
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.ToTable("role");
                });

            modelBuilder.Entity("CC.Yi.Model.shop", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<float>("discount")
                        .HasColumnType("float");

                    b.Property<int>("is_delete")
                        .HasColumnType("int");

                    b.Property<int>("number")
                        .HasColumnType("int");

                    b.Property<int>("price")
                        .HasColumnType("int");

                    b.Property<int?>("propid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("propid");

                    b.ToTable("shop");
                });

            modelBuilder.Entity("CC.Yi.Model.user", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .HasColumnType("longtext");

                    b.Property<string>("icon")
                        .HasColumnType("longtext");

                    b.Property<string>("ip")
                        .HasColumnType("longtext");

                    b.Property<int>("is_delete")
                        .HasColumnType("int");

                    b.Property<string>("nick")
                        .HasColumnType("longtext");

                    b.Property<string>("openid")
                        .HasColumnType("longtext");

                    b.Property<string>("password")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("time")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("user_extraid")
                        .HasColumnType("int");

                    b.Property<string>("username")
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.HasIndex("user_extraid");

                    b.ToTable("user");
                });

            modelBuilder.Entity("CC.Yi.Model.user_extra", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("experience")
                        .HasColumnType("int");

                    b.Property<string>("introduction")
                        .HasColumnType("longtext");

                    b.Property<int>("is_delete")
                        .HasColumnType("int");

                    b.Property<int>("level")
                        .HasColumnType("int");

                    b.Property<int>("num_release")
                        .HasColumnType("int");

                    b.Property<int>("num_reply")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("user_extra");
                });

            modelBuilder.Entity("CC.Yi.Model.version", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("color")
                        .HasColumnType("longtext");

                    b.Property<string>("context")
                        .HasColumnType("longtext");

                    b.Property<int>("is_delete")
                        .HasColumnType("int");

                    b.Property<DateTime?>("time")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("ver")
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.ToTable("version");
                });

            modelBuilder.Entity("CC.Yi.Model.warehouse", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("is_delete")
                        .HasColumnType("int");

                    b.Property<int>("number")
                        .HasColumnType("int");

                    b.Property<int?>("propid")
                        .HasColumnType("int");

                    b.Property<int?>("userid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("propid");

                    b.HasIndex("userid");

                    b.ToTable("warehouse");
                });

            modelBuilder.Entity("actionrole", b =>
                {
                    b.Property<int>("actionsid")
                        .HasColumnType("int");

                    b.Property<int>("rolesid")
                        .HasColumnType("int");

                    b.HasKey("actionsid", "rolesid");

                    b.HasIndex("rolesid");

                    b.ToTable("actionrole");
                });

            modelBuilder.Entity("actionuser", b =>
                {
                    b.Property<int>("actionsid")
                        .HasColumnType("int");

                    b.Property<int>("usersid")
                        .HasColumnType("int");

                    b.HasKey("actionsid", "usersid");

                    b.HasIndex("usersid");

                    b.ToTable("actionuser");
                });

            modelBuilder.Entity("discusslabel", b =>
                {
                    b.Property<int>("discussesid")
                        .HasColumnType("int");

                    b.Property<int>("labelsid")
                        .HasColumnType("int");

                    b.HasKey("discussesid", "labelsid");

                    b.HasIndex("labelsid");

                    b.ToTable("discusslabel");
                });

            modelBuilder.Entity("roleuser", b =>
                {
                    b.Property<int>("rolesid")
                        .HasColumnType("int");

                    b.Property<int>("usersid")
                        .HasColumnType("int");

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

            modelBuilder.Entity("CC.Yi.Model.article", b =>
                {
                    b.HasOne("CC.Yi.Model.article", null)
                        .WithMany("children")
                        .HasForeignKey("articleid");

                    b.HasOne("CC.Yi.Model.discuss", "discuss")
                        .WithMany("articles")
                        .HasForeignKey("discussid");

                    b.Navigation("discuss");
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

            modelBuilder.Entity("CC.Yi.Model.friend", b =>
                {
                    b.HasOne("CC.Yi.Model.user", "user1")
                        .WithMany()
                        .HasForeignKey("user1id");

                    b.HasOne("CC.Yi.Model.user", "user2")
                        .WithMany()
                        .HasForeignKey("user2id");

                    b.Navigation("user1");

                    b.Navigation("user2");
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

            modelBuilder.Entity("CC.Yi.Model.record", b =>
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

            modelBuilder.Entity("CC.Yi.Model.shop", b =>
                {
                    b.HasOne("CC.Yi.Model.prop", "prop")
                        .WithMany()
                        .HasForeignKey("propid");

                    b.Navigation("prop");
                });

            modelBuilder.Entity("CC.Yi.Model.user", b =>
                {
                    b.HasOne("CC.Yi.Model.user_extra", "user_extra")
                        .WithMany()
                        .HasForeignKey("user_extraid");

                    b.Navigation("user_extra");
                });

            modelBuilder.Entity("CC.Yi.Model.warehouse", b =>
                {
                    b.HasOne("CC.Yi.Model.prop", "prop")
                        .WithMany()
                        .HasForeignKey("propid");

                    b.HasOne("CC.Yi.Model.user", "user")
                        .WithMany()
                        .HasForeignKey("userid");

                    b.Navigation("prop");

                    b.Navigation("user");
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

            modelBuilder.Entity("CC.Yi.Model.article", b =>
                {
                    b.Navigation("children");
                });

            modelBuilder.Entity("CC.Yi.Model.discuss", b =>
                {
                    b.Navigation("articles");

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
