while true
do
    echo "Enter task name: "
    read taskdir
    dotnet new console -o $taskdir
    mv "$taskdir/Program.cs" "$taskdir/$taskdir.cs"
    sed -i 's#  <PropertyGroup>#  <PropertyGroup>\n    <DocumentationFile>bin\\$(Configuration)\\$(TargetFramework)\\$(AssemblyName).xml</DocumentationFile>#' "$taskdir/$taskdir.csproj"
done