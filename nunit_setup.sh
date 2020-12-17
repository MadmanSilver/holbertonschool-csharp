while true
do
    echo "Enter task directory: "
    read taskdir
    echo "Enter namespace: "
    read namespace
    mkdir $taskdir
    cd $taskdir
    dotnet new sln
    mkdir $namespace
    cd $namespace
    dotnet new classlib
    mv *.cs "$namespace.cs"
    sed -i 's#  <PropertyGroup>#  <PropertyGroup>\n    <DocumentationFile>bin\\$(Configuration)\\$(TargetFramework)\\$(AssemblyName).xml</DocumentationFile>#' "$namespace.csproj"
    cd ..
    dotnet sln add "$namespace/$namespace.csproj"
    mkdir "$namespace.Tests"
    cd "$namespace.Tests"
    dotnet new nunit
    mv *.cs "$namespace.Tests.cs"
    dotnet add reference "../$namespace/$namespace.csproj"
    cd ..
    dotnet sln add "$namespace.Tests/$namespace.Tests.csproj"
    cd ..
done