using FluentMigrator;

namespace DotNetPrototypes.Infrastructure.FluentMigrations;

[Migration(202111300001)]
public class InitialTables_202111300001 : Migration
{
    public override void Down()
    {
        Delete.Table("Coolers");
    }
    public override void Up()
    {
        Create.Table("Coolers")
            .WithColumn("Id").AsGuid().NotNullable().PrimaryKey().WithDefault(SystemMethods.NewGuid)
            .WithColumn("Name").AsString(50).NotNullable()
            .WithColumn("Rpm").AsInt32().NotNullable();
    }
}
