﻿// <auto-generated />
using System;
using Ghostly.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Ghostly.Data.Migrations
{
    [DbContext(typeof(GhostlyContext))]
    [Migration("20190922213035_EmojiMigration")]
    partial class EmojiMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("Ghostly.Data.Models.AccountData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AvatarUrl");

                    b.Property<int>("Discriminator");

                    b.Property<DateTime?>("LastSyncedAt");

                    b.Property<string>("Scopes");

                    b.Property<int>("State");

                    b.Property<string>("Username")
                        .HasColumnType("TEXT COLLATE NOCASE");

                    b.HasKey("Id");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("Ghostly.Data.Models.ActivityData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Category");

                    b.Property<int>("Constraint");

                    b.Property<int>("Kind");

                    b.Property<string>("Payload");

                    b.Property<DateTime>("Timestamp");

                    b.HasKey("Id");

                    b.ToTable("Activities");
                });

            modelBuilder.Entity("Ghostly.Data.Models.AssigneeData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Discriminator");

                    b.Property<int?>("UserId");

                    b.Property<int?>("WorkItemDataId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.HasIndex("WorkItemDataId");

                    b.ToTable("Assignees");
                });

            modelBuilder.Entity("Ghostly.Data.Models.CategoryData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Archive");

                    b.Property<bool>("Deletable");

                    b.Property<string>("Emoji");

                    b.Property<string>("Expression");

                    b.Property<string>("Glyph");

                    b.Property<bool>("Inbox");

                    b.Property<int>("Kind");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT COLLATE NOCASE");

                    b.Property<int>("SortOrder");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Ghostly.Data.Models.CommentData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AuthorId");

                    b.Property<string>("Body")
                        .HasColumnType("TEXT COLLATE NOCASE");

                    b.Property<DateTime?>("CreatedAt");

                    b.Property<int>("Discriminator");

                    b.Property<int?>("GitHubId");

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<string>("Url");

                    b.Property<int?>("WorkItemDataId");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("WorkItemDataId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("Ghostly.Data.Models.MilestoneData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Discriminator");

                    b.Property<long?>("GitHubId");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT COLLATE NOCASE");

                    b.HasKey("Id");

                    b.ToTable("Milestones");
                });

            modelBuilder.Entity("Ghostly.Data.Models.NotificationData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccountId");

                    b.Property<int?>("CategoryId");

                    b.Property<int>("Discriminator");

                    b.Property<int?>("GitHubId");

                    b.Property<bool>("Muted");

                    b.Property<string>("Reason")
                        .HasColumnType("TEXT COLLATE NOCASE");

                    b.Property<bool>("Starred");

                    b.Property<DateTime>("Timestamp");

                    b.Property<bool>("Unread");

                    b.Property<int?>("WorkItemId");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("WorkItemId");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("Ghostly.Data.Models.RepositoryData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Discriminator");

                    b.Property<bool>("Fork");

                    b.Property<long?>("GitHubId");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT COLLATE NOCASE");

                    b.Property<string>("Owner")
                        .HasColumnType("TEXT COLLATE NOCASE");

                    b.Property<bool>("Private");

                    b.HasKey("Id");

                    b.ToTable("Repositories");
                });

            modelBuilder.Entity("Ghostly.Data.Models.ReviewCommentData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AuthorId");

                    b.Property<string>("Body");

                    b.Property<string>("CommitId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Diff");

                    b.Property<long>("GitHubId");

                    b.Property<long?>("InReplyToId");

                    b.Property<string>("OriginalCommitId");

                    b.Property<int?>("OriginalPosition");

                    b.Property<string>("Path");

                    b.Property<int?>("Position");

                    b.Property<int?>("ReviewDataId");

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("ReviewDataId");

                    b.ToTable("ReviewComments");
                });

            modelBuilder.Entity("Ghostly.Data.Models.ReviewData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AuthorId");

                    b.Property<string>("Body");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("Discriminator");

                    b.Property<long>("GitHubId");

                    b.Property<int>("State");

                    b.Property<string>("Url");

                    b.Property<int?>("WorkItemDataId");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("WorkItemDataId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("Ghostly.Data.Models.RuleData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CategoryId");

                    b.Property<bool>("Enabled");

                    b.Property<string>("Expression");

                    b.Property<bool>("MarkAsRead");

                    b.Property<bool>("Mute");

                    b.Property<string>("Name");

                    b.Property<int>("SortOrder");

                    b.Property<bool>("Star");

                    b.Property<bool>("StopProcessing");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Rules");
                });

            modelBuilder.Entity("Ghostly.Data.Models.SyncItemData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Discriminator");

                    b.Property<string>("Identity");

                    b.Property<string>("Payload");

                    b.Property<DateTime>("Timestamp");

                    b.HasKey("Id");

                    b.ToTable("SyncItems");
                });

            modelBuilder.Entity("Ghostly.Data.Models.TagData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Color");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT COLLATE NOCASE");

                    b.Property<int>("Discriminator");

                    b.Property<long?>("GitHubId");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT COLLATE NOCASE");

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("Ghostly.Data.Models.UserData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AvatarHash");

                    b.Property<string>("AvatarUrl");

                    b.Property<int>("Discriminator");

                    b.Property<int?>("GitHubId");

                    b.Property<string>("Login")
                        .HasColumnType("TEXT COLLATE NOCASE");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT COLLATE NOCASE");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Ghostly.Data.Models.WorkItemData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AuthorId");

                    b.Property<string>("Body")
                        .HasColumnType("TEXT COLLATE NOCASE");

                    b.Property<string>("CommitSha");

                    b.Property<DateTime?>("CreatedAt");

                    b.Property<int>("Discriminator");

                    b.Property<long?>("GitHubId");

                    b.Property<int?>("GitHubLocalId");

                    b.Property<bool>("IsClosed");

                    b.Property<bool?>("IsCommit");

                    b.Property<bool?>("IsIssue");

                    b.Property<bool>("IsOpen");

                    b.Property<bool?>("IsPullRequest");

                    b.Property<bool?>("IsRelease");

                    b.Property<bool>("IsReopened");

                    b.Property<bool?>("IsVulnerability");

                    b.Property<bool?>("Locked");

                    b.Property<bool?>("Merged");

                    b.Property<DateTime?>("MergedAt");

                    b.Property<int?>("MergedById");

                    b.Property<int?>("MilestoneId");

                    b.Property<string>("Preamble")
                        .HasColumnType("TEXT COLLATE NOCASE");

                    b.Property<int?>("RepositoryId");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT COLLATE NOCASE");

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("MergedById");

                    b.HasIndex("MilestoneId");

                    b.HasIndex("RepositoryId");

                    b.ToTable("WorkItems");
                });

            modelBuilder.Entity("Ghostly.Data.Models.WorkItemTagData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("TagId");

                    b.Property<int>("WorkItemId");

                    b.HasKey("Id");

                    b.HasIndex("TagId");

                    b.HasIndex("WorkItemId");

                    b.ToTable("WorkItemTags");
                });

            modelBuilder.Entity("Ghostly.Data.Models.AssigneeData", b =>
                {
                    b.HasOne("Ghostly.Data.Models.UserData", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.HasOne("Ghostly.Data.Models.WorkItemData")
                        .WithMany("Assignees")
                        .HasForeignKey("WorkItemDataId");
                });

            modelBuilder.Entity("Ghostly.Data.Models.CommentData", b =>
                {
                    b.HasOne("Ghostly.Data.Models.UserData", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId");

                    b.HasOne("Ghostly.Data.Models.WorkItemData")
                        .WithMany("Comments")
                        .HasForeignKey("WorkItemDataId");
                });

            modelBuilder.Entity("Ghostly.Data.Models.NotificationData", b =>
                {
                    b.HasOne("Ghostly.Data.Models.CategoryData", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.HasOne("Ghostly.Data.Models.WorkItemData", "WorkItem")
                        .WithMany()
                        .HasForeignKey("WorkItemId");
                });

            modelBuilder.Entity("Ghostly.Data.Models.ReviewCommentData", b =>
                {
                    b.HasOne("Ghostly.Data.Models.UserData", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId");

                    b.HasOne("Ghostly.Data.Models.ReviewData")
                        .WithMany("Comments")
                        .HasForeignKey("ReviewDataId");
                });

            modelBuilder.Entity("Ghostly.Data.Models.ReviewData", b =>
                {
                    b.HasOne("Ghostly.Data.Models.UserData", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId");

                    b.HasOne("Ghostly.Data.Models.WorkItemData")
                        .WithMany("Reviews")
                        .HasForeignKey("WorkItemDataId");
                });

            modelBuilder.Entity("Ghostly.Data.Models.RuleData", b =>
                {
                    b.HasOne("Ghostly.Data.Models.CategoryData", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");
                });

            modelBuilder.Entity("Ghostly.Data.Models.WorkItemData", b =>
                {
                    b.HasOne("Ghostly.Data.Models.UserData", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId");

                    b.HasOne("Ghostly.Data.Models.UserData", "MergedBy")
                        .WithMany()
                        .HasForeignKey("MergedById");

                    b.HasOne("Ghostly.Data.Models.MilestoneData", "Milestone")
                        .WithMany()
                        .HasForeignKey("MilestoneId");

                    b.HasOne("Ghostly.Data.Models.RepositoryData", "Repository")
                        .WithMany()
                        .HasForeignKey("RepositoryId");
                });

            modelBuilder.Entity("Ghostly.Data.Models.WorkItemTagData", b =>
                {
                    b.HasOne("Ghostly.Data.Models.TagData", "Tag")
                        .WithMany()
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Ghostly.Data.Models.WorkItemData", "WorkItem")
                        .WithMany("Tags")
                        .HasForeignKey("WorkItemId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
