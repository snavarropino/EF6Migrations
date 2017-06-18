using CodeMigrationsAutomaticallyApplied.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeMigrationsAutomaticallyApplied
{
    class DatabaseInitializer : MigrateDatabaseToLatestVersion<SuperheroContext, Configuration>
    {
    }
}
