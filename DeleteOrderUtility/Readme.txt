1. Build the exe from https://github.com/xpologistics/xpo-partner-master/tree/master/tools/MigrationUtility
2. Copy "UserMigrationList.csv" to the EXE path
3. In Config file , change "<xpo environment="XXX" />" to the respective environment from where the tool is executing

                For QA the value should be <xpo environment="QA" />
		For UAT the value should be <xpo environment="Uat" />
                And for Prod it should be <xpo environment="Prod" />

4. Ensure the App.config --> appsettings is as follows for Prod

  <appSettings>
    <add key="filePath" value="UserMigrationList.csv" />
    <add key="PartnerMasterCoreBaseApi" value="https://partner-manager.xpoapi.com" />
    <add key="PmApiScope" value="xpo-partner-master-api" />
    <add key="AuthorityUri" value="https://login.authxpo.com/" />
    <add key="PmApiBasePath" value="https://partner-manager.xpoapi.com/" />
    <add key="MigrateAppClientId" value="xpo-partner-master-authorization-middleware" />
    <add key="MigrateAppClientSecret" value="E9K96UGeA56lmi1NG2MIJBvOEl3phCpmbO5ECMGjQFhYlRvn8FR92a33j2LttnEab" />
  </appSettings>

5. Log file will be generated in Logs folder.

6. After running the tool leave the console window open for a minute to allow all the threads to complete exectuion.


------------------------------------------------------OR---------------------------------------------------------------  

1. Get the precompiled code from https://github.com/xpologistics/xpo-partner-master/tree/master/tools/MigrationUtility/PreCompiledCode

2. Copy the config from MigrationUtility.exe.<Env>.config file to MigrationUtility.exe.config
For Example : If the tool is run in Prod then copy the config from MigrationUtility.exe.Prod.config to MigrationUtility.exe.config


3. Copy "UserMigrationList.csv" to the EXE path

4. Run MigrationUtility.exe. 

5. Log file will be generated in Logs folder.

6. After running the tool leave the console window open for a minute to allow all the threads to complete execution. 