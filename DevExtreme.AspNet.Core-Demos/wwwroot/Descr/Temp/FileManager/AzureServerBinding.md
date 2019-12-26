This demo illustrates how to configure the **FileManager** widget to manage files and folders in Microsoft Azure Blob Storage. To access the Azure Blob Storage, the widget uses the [Remote File Provider](/Documentation/ApiReference/UI_Widgets/dxFileManager/File_Providers/Remote).
This file provider allows you to access the storage's file system on the client side. To process the HTTP requests on the server, create your own file provider to implement the [IFileProvider](https://docs.devexpress.com/AspNetCore/DevExtreme.AspNet.Mvc.FileManagement.IFileProvider) interface.