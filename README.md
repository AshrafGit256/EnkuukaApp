# Enkuuka y'Omwaka — ASP.NET Core Web App

Royal Buganda New Year Festival website converted from React to ASP.NET Core 8 Razor Pages.

---

## Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) installed on your machine

Verify with:
```bash
dotnet --version
```

---

## Running the Project

### Option 1 — Command Line

```bash
cd EnkuukaApp
dotnet run
```

Then open your browser at: **https://localhost:5001** or **http://localhost:5000**

### Option 2 — Visual Studio 2022+

1. Open `EnkuukaApp.csproj` in Visual Studio
2. Press **F5** or click the Run button

### Option 3 — Visual Studio Code

1. Open the `EnkuukaApp` folder in VS Code
2. Install the **C# Dev Kit** extension
3. Press `F5` to run

---

## Project Structure

```
EnkuukaApp/
├── Models/
│   └── SiteData.cs          ← All data (Masaza, Clans, Hotels, Programme)
├── Pages/
│   ├── Shared/
│   │   └── _Layout.cshtml   ← Nav + Footer shared layout
│   ├── Index.cshtml          ← Home page
│   ├── Culture.cshtml        ← Buganda culture & traditions
│   ├── Clans.cshtml          ← 52 Clans with search & filter
│   ├── Masaza.cshtml         ← 18 Counties with interactive list
│   ├── Events.cshtml         ← Full day events timeline
│   ├── Entertainment.cshtml  ← Artists & performance schedule
│   ├── Business.cshtml       ← Trade fair & vendor packages
│   ├── Programme.cshtml      ← Day programme timeline
│   ├── Gallery.cshtml        ← Photo gallery with lightbox
│   ├── Accommodation.cshtml  ← Hotels & transport info
│   ├── Invitation.cshtml     ← Personalised digital invitation
│   └── Contact.cshtml        ← Contact form & info
├── wwwroot/
│   ├── css/site.css          ← All styles (converted from React theme)
│   └── js/site.js            ← Countdown, search, gallery, tabs
├── Program.cs
└── EnkuukaApp.csproj
```

---

## Pages

| URL | Page |
|---|---|
| `/` | Home — Hero, countdown, highlights |
| `/Culture` | Buganda culture & traditions |
| `/Clans` | 52 Clans with live search |
| `/Masaza` | 18 Counties with interactive map |
| `/Events` | Full day event timeline |
| `/Entertainment` | Artists & performance schedule |
| `/Business` | Trade fair & vendor packages |
| `/Programme` | Full day programme |
| `/Gallery` | Photo gallery with lightbox |
| `/Accommodation` | Hotels & transport |
| `/Invitation` | Personalised digital invitation |
| `/Contact` | Contact form |

---

## Fonts & External Resources

Fonts are loaded from Google Fonts (internet connection required):
- Cormorant Garamond
- Bebas Neue
- DM Sans

Images are loaded from GitHub raw files (the original React app's asset URLs).

---

## Customisation

- **Data** — Edit `Models/SiteData.cs` to update Masaza, Clans, Hotels, or Programme entries
- **Styles** — Edit `wwwroot/css/site.css`
- **Interactivity** — Edit `wwwroot/js/site.js`
- **Pages** — Each `.cshtml` file in `Pages/` is a self-contained Razor page

---

Built with ASP.NET Core 8 · Razor Pages · No external NuGet packages required
