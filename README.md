# 6th Semester .NET Lab

## Purpose and Content of the Repository

This repository contains practical lab exercises for the 6th semester .NET course. It includes various C# programs and ASP.NET Core applications that demonstrate different concepts and techniques covered in the course.

## How to Clone the Repository

To clone the repository, use the following command:

```bash
git clone https://github.com/sachinthapa572/6th_sem_dotnet_lab.git
```

## How to Navigate into the Cloned Folder

After cloning the repository, navigate into the cloned folder using the following command:

```sh
cd 6th_sem_dotnet_lab
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

## How to Run the Program

To run the program, follow these steps:

1. Open a terminal or command prompt.
2. Navigate to the folder containing the `Program.cs` file.
3. Uncomment the code in the `Program.cs` file that you want to run. You can do this by removing the comment markers (`//`) from the lines of code you want to execute.
4. Run the following command to execute the program:

```sh
dotnet run
```

## how to run the Remaning Questions

1. Open the terminal or command prompt.

   ```sh
   cd Codes/database
   dotnet watch run
   ```

## Repository Structure

The repository contains the following structure:

- `Codes/`: This folder contains various code files organized by chapters.
- `Program.cs`: This is the main entry point of the program.
