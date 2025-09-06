# 🤝 Contributing to TaskFlow

Thanks for your interest in contributing! This guide explains how to set up the project, run tests, and manage database migrations.

## 🚀 Workflow
- The `main` branch is protected, direct pushes are not allowed.  
- All changes must go through a Pull Request (PR).  
- Required checks before merging:
  - ✅ Build succeeds  
  - ✅ All unit/integration tests pass   

## 🔧 Development Setup

## 🗄️ Database (Entity Framework Core)
We use **EF Core Code-First Migrations**.

### Add a new migration
```bash
dotnet ef migrations add <MigrationName> --project Infrastructure --startup-project Presentation
```

### Apply migrations
```bash
dotnet ef database update --project Infrastructure --startup-project Presentation
```