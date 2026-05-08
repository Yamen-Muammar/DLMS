# DVLD — Driving & Vehicle Licenses Department System

A full-featured desktop application that simulates the operations of a government licensing authority. Built in C# with a strict 3-tier architecture, it handles everything from first-time applicants to license detention, test scheduling, and user access control.

---

## What This Is

DVLD covers the full lifecycle of a driving license: application, examination, issuance, renewal, replacement, and detention. It also manages the people registry and system users under a role-based access model. The goal was to replicate how a real licensing department operates — end to end — in a single desktop system.

---

## Tech Stack

| Layer | Technology |
|---|---|
| Language | C# (.NET) |
| UI Framework | Windows Forms (WinForms) |
| Database | Microsoft SQL Server |
| Data Access | ADO.NET |
| Architecture | 3-Tier (Presentation / Business / Data) |

---

## Project Structure

```
DVLD/
├── DVLD -Core/                  # Shared models and enums used across layers
├── DVLD -Data Tier/             # ADO.NET data access — all DB calls live here
├── DVLD -Business Tier/         # Business logic, validation, workflow rules
└── DVLD -Presentation Tier/     # WinForms UI — forms, controls, dialogs
```

Each layer only talks to the one directly below it. The UI never touches the database.

---

## Features

### License Applications

- **New Local License** — full first-time applicant workflow: person lookup, category selection, fee calculation, and test scheduling
- **International License** — issued against an existing valid local license, no tests required
- **License Renewal** — handles expired licenses; validates eligibility before reissuing
- **Replace Lost License** — issues a duplicate after verifying identity and logging the reason
- **Replace Damaged License** — replaces a physically damaged card; the old card is marked void

### Detention & Release

- Detain an active license (e.g. court order or infraction), locking it from renewal or use
- Release a detained license after verifying fine payment and clearing status

### Examination System

Three-stage test process — all three must pass before a license is issued:

1. **Vision Test** — basic visual acuity check
2. **Written Test** — theory and traffic rules
3. **Practical / Street Test** — on-road driving assessment

Failed tests can be rescheduled. Every attempt — pass or fail — is logged with date and examiner info.

### License Classes

The system supports multiple license categories, each with its own age requirement and fee structure:

| Class | Description |
|---|---|
| Class 1 | Small Motorcycles |
| Class 2 | Heavy Motorcycles |
| Class 3 | Regular Private Vehicles |
| Class 4 | Agricultural Vehicles |
| Class 5 | Taxis & Small Commercial |
| Class 6 | Medium Commercial |
| Class 7 | Heavy Trucks & Buses |

### People Registry

A centralized registry stores personal records (National ID, name, date of birth, contact info, address, photo) that are reused across the system. One person record links to all their licenses, applications, and test history.

### User & Access Management

- Create and manage system users tied to people records
- Assign roles with specific permissions
- Enable or disable accounts
- Controlled password management

---

## Getting Started

### Prerequisites

- Windows OS
- Visual Studio 2022 or later
- SQL Server (Express works fine)
- .NET Framework 4.x or .NET 6+

### Setup

1. Clone the repo:
   ```bash
   git clone https://github.com/Yamen-Muammar/DVLD.git
   ```

2. Open `DVLD.sln` in Visual Studio.

3. Restore the database:
   - Open SQL Server Management Studio
   - Restore the `.bak` file included in the project (or run the provided SQL script)
   - Update the connection string in the Data Tier project to point to your SQL Server instance

4. Set `DVLD -Presentation Tier` as the startup project.

5. Build and run.

**Default login:** `y1` / `1`

---

## Architecture Notes

The 3-tier split is strict by design:

- **Presentation Tier** handles only UI concerns — no SQL, no business rules
- **Business Tier** validates inputs, enforces rules (e.g. "can't renew a detained license"), and coordinates workflows
- **Data Tier** handles all database reads and writes via ADO.NET stored procedures and parameterized queries

The `DVLD -Core` project holds shared types (enums, constants, utility classes) that both the Business and Data tiers reference, avoiding circular dependencies.

---

## Screenshots

> *(Add screenshots of the main dashboard, license application form, and test scheduling screen here)*

---

## License

This project is open source. Feel free to fork, study, or build on it.
