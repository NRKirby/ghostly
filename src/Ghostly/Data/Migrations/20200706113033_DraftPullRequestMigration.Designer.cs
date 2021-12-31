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
    [Migration("20200706113033_DraftPullRequestMigration")]
    partial class DraftPullRequestMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5");

            modelBuilder.Entity("Ghostly.Data.Models.AccountData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AvatarUrl")
                        .HasColumnType("TEXT");

                    b.Property<int>("Discriminator")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("LastSyncedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Scopes")
                        .HasColumnType("TEXT");

                    b.Property<int>("State")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Username")
                        .HasColumnType("TEXT COLLATE NOCASE");

                    b.HasKey("Id");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("Ghostly.Data.Models.ActivityData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Category")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Constraint")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Kind")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Payload")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Activities");
                });

            modelBuilder.Entity("Ghostly.Data.Models.AssigneeData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Discriminator")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("WorkItemDataId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.HasIndex("WorkItemDataId");

                    b.ToTable("Assignees");
                });

            modelBuilder.Entity("Ghostly.Data.Models.CategoryData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Archive")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Deletable")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Emoji")
                        .HasColumnType("TEXT");

                    b.Property<string>("Expression")
                        .HasColumnType("TEXT");

                    b.Property<string>("Glyph")
                        .HasColumnType("TEXT");

                    b.Property<string>("Identifier")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("ImportedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImportedFrom")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Inbox")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Kind")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT COLLATE NOCASE");

                    b.Property<int>("SortOrder")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Ghostly.Data.Models.CommentData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("AuthorId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Body")
                        .HasColumnType("TEXT COLLATE NOCASE");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<int>("Discriminator")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("GitHubId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.Property<int?>("WorkItemDataId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("WorkItemDataId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("Ghostly.Data.Models.MilestoneData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Discriminator")
                        .HasColumnType("INTEGER");

                    b.Property<long?>("GitHubId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT COLLATE NOCASE");

                    b.HasKey("Id");

                    b.ToTable("Milestones");
                });

            modelBuilder.Entity("Ghostly.Data.Models.NotificationData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AccountId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Discriminator")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("GitHubId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Muted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Reason")
                        .HasColumnType("TEXT COLLATE NOCASE");

                    b.Property<bool>("Starred")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Unread")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("WorkItemId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("WorkItemId");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("Ghostly.Data.Models.RepositoryData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Discriminator")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Fork")
                        .HasColumnType("INTEGER");

                    b.Property<long?>("GitHubId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT COLLATE NOCASE");

                    b.Property<string>("Owner")
                        .HasColumnType("TEXT COLLATE NOCASE");

                    b.Property<bool>("Private")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Repositories");
                });

            modelBuilder.Entity("Ghostly.Data.Models.ReviewCommentData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("AuthorId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Body")
                        .HasColumnType("TEXT");

                    b.Property<string>("CommitId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Diff")
                        .HasColumnType("TEXT");

                    b.Property<long>("GitHubId")
                        .HasColumnType("INTEGER");

                    b.Property<long?>("InReplyToId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("OriginalCommitId")
                        .HasColumnType("TEXT");

                    b.Property<int?>("OriginalPosition")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Path")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Position")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ReviewDataId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("ReviewDataId");

                    b.ToTable("ReviewComments");
                });

            modelBuilder.Entity("Ghostly.Data.Models.ReviewData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("AuthorId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Body")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<int>("Discriminator")
                        .HasColumnType("INTEGER");

                    b.Property<long>("GitHubId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("State")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.Property<int?>("WorkItemDataId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("WorkItemDataId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("Ghostly.Data.Models.RuleData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Enabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Expression")
                        .HasColumnType("TEXT");

                    b.Property<string>("Identifier")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("ImportedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImportedFrom")
                        .HasColumnType("TEXT");

                    b.Property<bool>("MarkAsRead")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Mute")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("SortOrder")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Star")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("StopProcessing")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Rules");
                });

            modelBuilder.Entity("Ghostly.Data.Models.SyncItemData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Discriminator")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Identity")
                        .HasColumnType("TEXT");

                    b.Property<string>("Payload")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("SyncItems");
                });

            modelBuilder.Entity("Ghostly.Data.Models.TagData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Color")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT COLLATE NOCASE");

                    b.Property<int>("Discriminator")
                        .HasColumnType("INTEGER");

                    b.Property<long?>("GitHubId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT COLLATE NOCASE");

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("Ghostly.Data.Models.UserData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AvatarHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("AvatarUrl")
                        .HasColumnType("TEXT");

                    b.Property<int>("Discriminator")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("GitHubId")
                        .HasColumnType("INTEGER");

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
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("AuthorId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Body")
                        .HasColumnType("TEXT COLLATE NOCASE");

                    b.Property<string>("CommitSha")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<int>("Discriminator")
                        .HasColumnType("INTEGER");

                    b.Property<long?>("GitHubId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("GitHubLocalId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsClosed")
                        .HasColumnType("INTEGER");

                    b.Property<bool?>("IsCommit")
                        .HasColumnType("INTEGER");

                    b.Property<bool?>("IsDraft")
                        .HasColumnType("INTEGER");

                    b.Property<bool?>("IsIssue")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsOpen")
                        .HasColumnType("INTEGER");

                    b.Property<bool?>("IsPullRequest")
                        .HasColumnType("INTEGER");

                    b.Property<bool?>("IsRelease")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsReopened")
                        .HasColumnType("INTEGER");

                    b.Property<bool?>("IsVulnerability")
                        .HasColumnType("INTEGER");

                    b.Property<bool?>("Locked")
                        .HasColumnType("INTEGER");

                    b.Property<bool?>("Merged")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("MergedAt")
                        .HasColumnType("TEXT");

                    b.Property<int?>("MergedById")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("MilestoneId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Preamble")
                        .HasColumnType("TEXT COLLATE NOCASE");

                    b.Property<int?>("RepositoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT COLLATE NOCASE");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

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
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("TagId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("WorkItemId")
                        .HasColumnType("INTEGER");

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

                    b.HasOne("Ghostly.Data.Models.WorkItemData", null)
                        .WithMany("Assignees")
                        .HasForeignKey("WorkItemDataId");
                });

            modelBuilder.Entity("Ghostly.Data.Models.CommentData", b =>
                {
                    b.HasOne("Ghostly.Data.Models.UserData", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId");

                    b.HasOne("Ghostly.Data.Models.WorkItemData", null)
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

                    b.HasOne("Ghostly.Data.Models.ReviewData", null)
                        .WithMany("Comments")
                        .HasForeignKey("ReviewDataId");
                });

            modelBuilder.Entity("Ghostly.Data.Models.ReviewData", b =>
                {
                    b.HasOne("Ghostly.Data.Models.UserData", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId");

                    b.HasOne("Ghostly.Data.Models.WorkItemData", null)
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
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ghostly.Data.Models.WorkItemData", "WorkItem")
                        .WithMany("Tags")
                        .HasForeignKey("WorkItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
