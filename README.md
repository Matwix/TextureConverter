# TextureConverter

**Texture Converter and Scaler for Enfusion**

TextureConverter is a versatile desktop application designed for users working with texture files in game development, specifically tailored for the **Enfusion Engine** (used in games like Arma) and **Unreal Engine**. It provides tools for converting and scaling textures between different formats, making the process smoother for game modders and developers.

## Prerequisites

Before running **TextureConverter**, ensure you have the following installed:

- **.NET 6.0 Framework**  
  This application is built using .NET 6.0, so you'll need to have it installed on your system. You can download it from the official Microsoft website:  
  [Download .NET 6.0](https://dotnet.microsoft.com/download/dotnet/6.0)

- **Magick.NET**  
  This app relies on **Magick.NET**, a .NET wrapper for the ImageMagick library, to handle image processing tasks. It is required for texture conversions and scaling. If not already installed, Magick.NET will be included in the project's dependencies.

## Installation

1. Download the latest version of **TextureConverter** from the [Releases](https://github.com/yourusername/TextureConverter/releases) section.
2. Extract the files to a folder of your choice.
3. Ensure that **.NET 6.0** is installed on your machine (see the prerequisites section).
4. Run the application by double-clicking `TextureConverter.exe`.

If **Magick.NET** is not already installed, the necessary dependencies will be handled automatically during installation.

## Usage

Once the application is launched, you'll be greeted with a splash screen that offers three buttons for the different tools:

- **Launch Unreal to Enfusion Converter**: Select this option if you're working with Unreal Engine textures and need to convert them to Enfusion Engine format (BCR/NMO).
  
- **Launch PBR to Enfusion Converter**: Use this option for converting PBR textures to Enfusion Engine format (BCR/NMO), making them ready for use in your Enfusion-based projects.
  
- **Launch Texture Scaler**: This option allows you to scale and resize your textures to the preferred resolution.

Simply click the appropriate button for the task you'd like to perform, and follow the on-screen instructions.

## Support

If you encounter any issues, please open an issue on the [GitHub Issues](https://github.com/Matwix/TextureConverter/issues) page. Be sure to include detailed information about the problem, your system, and any relevant screenshots or error messages.

## Contributing

Contributions are welcome! If you'd like to contribute to this project, please follow these steps:

1. Fork the repository.
2. Create a new branch (`git checkout -b feature-name`).
3. Commit your changes (`git commit -am 'Add new feature'`).
4. Push to the branch (`git push origin feature-name`).
5. Open a pull request.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Third-Party Libraries

This project uses the following third-party libraries:

- **Magick.Native** (ImageMagick .NET binding)  
  Licensed under the Apache License, Version 2.0.
  Copyright (c) 2024 dlemstra
  For more details, see [LICENSE-APACHE](LICENSE-APACHE).
