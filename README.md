# C# API avec Core framework et Entity Framework

Ce projet fait partie de l'étude de la consommation énergétique des frameworks
de développement en conditions réelles.

Des informations sur le protocole utilisé pour les tests se trouve [ici](https://github.com/axopen-power-benchmark/setup-benchmark)

## Dépendances

Pour compiler le projet les dépendances suivantes doivent être installé :
```
dotnet
```

## Compilation

```shell
# Build
dotnet build -c Release

# Démarrage du serveur
csharp-api\bin\Release\net6.0\csharp-api.exe

```

## Configuration

Dans dossier courant lors du lancement de l'API doit se trouver un fichier 
```appsettings.json``` au même format que celui se trouvant dans ```./csharp-api/appsettings.json```

On retrouve la configuration de la base de données dans ce fichier :
```json
{
    "ConnectionStrings": {
        "Database": "Server=127.0.0.1; Port=3307; Database=power_benchmark_2; Uid=user; Password=password; SslMode=Preferred;"
    },
    ...
}
```

## Route

### GET /api/chantier

Retourne un chantier random en mode eager

### POST /api/chantier

Update un chantier random avec des valeurs random et retourne le chantier updater
