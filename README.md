# Market Management System

## Overview

Market Management System is a layered C# Windows Forms learning project built on .NET Framework 4.8.1. It uses Entity Framework 6 with SQL Server for product, user, sale, and report data.

The current code includes user sign-in, inventory management, product filtering, barcode lookup, camera-based scanning, and a sales screen that calculates running totals.

## Main Features

- Database-backed user sign-in
- Product list, add, update, and delete operations
- Search by product name, category, and brand
- Manual barcode lookup
- Camera-based barcode scanning with AForge and ZXing
- Sales grid with quantity updates
- Running sales total calculation
- Cash-register selection when recording a sale
- Creation of sale report records

> A report screen exists in the UI, but report listing and filtering are not currently wired to the data layer. It is not listed as a completed reporting feature.

## Technologies

- C#
- Windows Forms
- .NET Framework 4.8.1
- Microsoft SQL Server
- Entity Framework 6.4.4
- AForge 2.2.5
- ZXing.Net 0.16.9
- DevExpress 23.2 UI components

## Architecture

The solution is divided into four projects:

- MarketDatabase.FormUI — Windows Forms and DevExpress user interface
- MarketDatabse.Business — application managers and business-facing operations
- MarketDatabase.DataAccess — Entity Framework context, interfaces, and data-access implementations
- MarketDatabase.Entities — data entities

The UI depends on business managers, which depend on data-access interfaces and EF-backed implementations.

## Prerequisites

- Windows
- Visual Studio with .NET desktop development tools
- .NET Framework 4.8.1 Developer Pack
- Microsoft SQL Server
- Entity Framework 6 package restore
- DevExpress 23.2 assemblies and an appropriate local installation/license
- A camera for optional barcode scanning

## Installation

1. Clone the repository:

   ~~~text
   git clone https://github.com/omeryssl/Market-Otomasyonu.git
   ~~~

2. Open MarketDatabase.DataAccess/MarketDatabase.sln in Visual Studio.
3. Restore the NuGet packages used by the solution.
4. Confirm that the required DevExpress 23.2 assemblies are available locally.
5. Prepare a local SQL Server database compatible with the current entity model.
6. Configure a private local connection string without committing machine-specific values.

## Database Setup

The Entity Framework context uses the ContextMarketDatabase connection name.

The included migration represents an earlier schema and currently creates only initial stock and sale tables. It does not provide a complete reproducible schema for the current user and report entities. Until migrations are aligned with the current model, the application requires an existing local database that matches the current entities.

Do not publish real user credentials, sales records, or private connection details.

## Configuration

Set the ContextMarketDatabase connection in a private local configuration for your SQL Server instance. Keep server names, credentials, and private endpoints out of public commits.

The application references DevExpress 23.2 directly. Contributors must have compatible assemblies available before the UI project can be built.

## How to Run

The current checkout requires source and database corrections before a clean run can be documented:

- The cash-register report form calls a manager contract that does not match the current implementation.
- The current EF migration does not cover all entity sets used by sign-in and reporting.

After those issues are corrected and reviewed separately:

1. Start the compatible local SQL Server database.
2. Select MarketDatabase.FormUI as the startup project.
3. Build and run the solution in Visual Studio.
4. Sign in with a fictional local demo user.
5. Review product management, search, barcode, and sales flows.

## Screenshots

No recruiter-facing screenshots are currently committed. Planned images will be stored under docs/images/ after the application can be built and run with fictional data:

- sign-in.png
- main-dashboard.png
- product-management.png
- barcode-lookup.png
- sales-screen.png

A report screenshot should not be added until report loading and filtering are implemented and verified.

## Known Limitations

- The current checkout contains a compile-time contract mismatch in the cash-register reporting flow
- Entity Framework migrations do not represent the complete current model
- The report UI is not connected to report data
- User passwords are compared as plain values instead of using a password-hashing flow
- DevExpress 23.2 is an external build prerequisite
- Generated build outputs, IDE files, package binaries, and PDB files are committed
- No automated tests
- The UI is currently Turkish

## Possible Future Improvements

- Align the report manager contract and report UI
- Add complete Entity Framework migrations for the current model
- Replace plain password comparison with a safe password-storage approach
- Improve input validation and error handling
- Add stock reduction rules and transaction handling to the sales flow
- Add automated tests for managers and data access
- Remove generated build artifacts from version control

## Project Status

Portfolio learning project demonstrating a layered Windows Forms structure, Entity Framework 6, SQL Server, product management, barcode operations, and sales-total workflows. Some reporting and database setup areas remain incomplete and are documented under Known Limitations.

## Author and Contact

Ömer Yeşil

[GitHub](https://github.com/omeryssl) · [LinkedIn](https://www.linkedin.com/in/omer-yesil-developer/)
