# 6th Semester .NET Lab

## How to Clone the Repository

To clone the repository, use the following command:

```bash
git clone https://github.com/sachinthapa572/6th_sem_dotnet_lab.git
```

## How to Update the .NET Version

To update the .NET version in the project, follow these steps:

- Open the `dotnet.csproj` file in a text editor or IDE.
- Locate the `<TargetFramework>` tag.
- Replace the existing version with the version installed on your local machine. You can check your local version using:

    ```bash
    dotnet --version
    ```

- Save the changes to the `dotnet.csproj` file.
- Run the following command to ensure the project uses the updated version:

    ```bash
    dotnet restore
    ```


## How to Navigate into the Cloned Folder

After cloning the repository, navigate into the cloned folder using the following command:

```sh
cd 6th_sem_dotnet_lab
```

## How to Run the Program

To run the program, follow these steps:

1. Open a terminal or command prompt.
2. Navigate to the folder containing the `Program.cs` file.
3. Run the following command to execute the program:

```sh
dotnet run
```

## Repository Structure

The repository contains the following structure:

- `Codes/`: This folder contains various code files organized by chapters.
- `Program.cs`: This is the main entry point of the program.
