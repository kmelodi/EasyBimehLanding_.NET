# Getting started

EasyBimehConnect 

 یک ساب برند از ایزی بیمه است که وظیفه ارائه خدمات

 B2B و B2B2C

را برپایه وب سرویس و وایت لیبل بر عهده دارد. اگر اپلیکیشن و یا سایت غیر بیمه‌ای دارید و تمایل به فروش بیمه نامه دارید از امروز میتوانید با کمترین هزینه و کمترین زمان به زنجیره نوآوری در صنعت بیمه متصل شوید و تجارت جدیدی بسازید

به دلیل گستردگی پروژه و برای دسترسی بهتر، این پروژه به بخش های مختلف تقسیم شده است

و هر بخش در 10 پلتفرم مختلف، ارایه شده است

در این بخش، به وب سرویس های مربوط به صفحه ی لندینگ مرکز بیمه، دسترسی خواهید داشت که 

اطلاعات هر پلتفرم را میتوانید بصورت تجمیعی در آدرس زیر مشاهده نمایید

https://www.apimatic.io/apidocs/easybimehlanding

و یا بصورت مجزا در آدرس های زیر قابل درسترس می باشند

1- Android: https://github.com/kmelodi/EasyBimehLanding_Android

2- .Net: https://github.com/kmelodi/EasyBimehLanding_.NET

3- Ios: https://github.com/kmelodi/EasyBimehLanding_IOS

4- Java: https://github.com/kmelodi/EasyBimehLanding_JAVA

5- Php: https://github.com/kmelodi/EasyBimehLanding_PHP

6- Python: https://github.com/kmelodi/EasyBimehLanding_Python

7- Ruby: https://github.com/kmelodi/EasyBimehLanding_Ruby

8- Angular: https://github.com/kmelodi/EasyBimehLanding_Angular

9- NodeJs: https://github.com/kmelodi/EasyBimehLanding_NodeJs

10- Go: https://github.com/kmelodi/EasyBimehLanding_Go


برای اطلاعات بیشتر به آدرس زیر مراجعه نمایید

https://easybimeh.com/ebconnect

## How to Build

The generated code uses the Newtonsoft Json.NET NuGet Package. If the automatic NuGet package restore
is enabled, these dependencies will be installed automatically. Therefore,
you will need internet access for build.

"This library requires Visual Studio 2017 for compilation."
1. Open the solution (EasyBimehLanding.sln) file.
2. Invoke the build process using `Ctrl+Shift+B` shortcut key or using the `Build` menu as shown below.

![Building SDK using Visual Studio](https://apidocs.io/illustration/cs?step=buildSDK&workspaceFolder=Easy%20Bimeh%20Landing-CSharp&workspaceName=EasyBimehLanding&projectName=EasyBimehLanding.Tests)

## How to Use

The build process generates a portable class library, which can be used like a normal class library. The generated library is compatible with Windows Forms, Windows RT, Windows Phone 8,
Silverlight 5, Xamarin iOS, Xamarin Android and Mono. More information on how to use can be found at the [MSDN Portable Class Libraries documentation](http://msdn.microsoft.com/en-us/library/vstudio/gg597391%28v=vs.100%29.aspx).

The following section explains how to use the EasyBimehLanding library in a new console project.

### 1. Starting a new project

For starting a new project, right click on the current solution from the *solution explorer* and choose  ``` Add -> New Project ```.

![Add a new project in the existing solution using Visual Studio](https://apidocs.io/illustration/cs?step=addProject&workspaceFolder=Easy%20Bimeh%20Landing-CSharp&workspaceName=EasyBimehLanding&projectName=EasyBimehLanding.Tests)

Next, choose "Console Application", provide a ``` TestConsoleProject ``` as the project name and click ``` OK ```.

![Create a new console project using Visual Studio](https://apidocs.io/illustration/cs?step=createProject&workspaceFolder=Easy%20Bimeh%20Landing-CSharp&workspaceName=EasyBimehLanding&projectName=EasyBimehLanding.Tests)

### 2. Set as startup project

The new console project is the entry point for the eventual execution. This requires us to set the ``` TestConsoleProject ``` as the start-up project. To do this, right-click on the  ``` TestConsoleProject ``` and choose  ``` Set as StartUp Project ``` form the context menu.

![Set the new cosole project as the start up project](https://apidocs.io/illustration/cs?step=setStartup&workspaceFolder=Easy%20Bimeh%20Landing-CSharp&workspaceName=EasyBimehLanding&projectName=EasyBimehLanding.Tests)

### 3. Add reference of the library project

In order to use the EasyBimehLanding library in the new project, first we must add a projet reference to the ``` TestConsoleProject ```. First, right click on the ``` References ``` node in the *solution explorer* and click ``` Add Reference... ```.

![Open references of the TestConsoleProject](https://apidocs.io/illustration/cs?step=addReference&workspaceFolder=Easy%20Bimeh%20Landing-CSharp&workspaceName=EasyBimehLanding&projectName=EasyBimehLanding.Tests)

Next, a window will be displayed where we must set the ``` checkbox ``` on ``` EasyBimehLanding.Tests ``` and click ``` OK ```. By doing this, we have added a reference of the ```EasyBimehLanding.Tests``` project into the new ``` TestConsoleProject ```.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=createReference&workspaceFolder=Easy%20Bimeh%20Landing-CSharp&workspaceName=EasyBimehLanding&projectName=EasyBimehLanding.Tests)

### 4. Write sample code

Once the ``` TestConsoleProject ``` is created, a file named ``` Program.cs ``` will be visible in the *solution explorer* with an empty ``` Main ``` method. This is the entry point for the execution of the entire solution.
Here, you can add code to initialize the client library and acquire the instance of a *Controller* class. Sample code to initialize the client library and using controller methods is given in the subsequent sections.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=addCode&workspaceFolder=Easy%20Bimeh%20Landing-CSharp&workspaceName=EasyBimehLanding&projectName=EasyBimehLanding.Tests)

## How to Test

The generated SDK also contain one or more Tests, which are contained in the Tests project.
In order to invoke these test cases, you will need *NUnit 3.0 Test Adapter Extension for Visual Studio*.
Once the SDK is complied, the test cases should appear in the Test Explorer window.
Here, you can click *Run All* to execute these test cases.

## Initialization

### 

API client can be initialized as following.

```csharp

EasyBimehLandingClient client = new EasyBimehLandingClient();
```



# Class Reference

## <a name="list_of_controllers"></a>List of Controllers

* [FileManagerController](#file_manager_controller)
* [LiabilityDoctorInsuranceController](#liability_doctor_insurance_controller)
* [CarBodyController](#car_body_controller)
* [ElectronicEquipmentInsuranceController](#electronic_equipment_insurance_controller)
* [OtherInsuranceTypesController](#other_insurance_types_controller)
* [ThirdPartyInsuranceController](#third_party_insurance_controller)
* [MotorcycleInsuranceController](#motorcycle_insurance_controller)
* [FireInsuranceController](#fire_insurance_controller)
* [EarthquakeInsuranceController](#earthquake_insurance_controller)
* [TravelInsuranceController](#travel_insurance_controller)
* [ElevatorInsuranceController](#elevator_insurance_controller)
* [MainController](#main_controller)
* [ComboDataController](#combo_data_controller)
* [TrackingDamageController](#tracking_damage_controller)
* [FooterController](#footer_controller)
* [InsurancePolicyPlanController](#insurance_policy_plan_controller)

## <a name="file_manager_controller"></a>![Class: ](https://apidocs.io/img/class.png "EasyBimehLanding.Tests.Controllers.FileManagerController") FileManagerController

### Get singleton instance

The singleton instance of the ``` FileManagerController ``` class can be accessed from the API Client.

```csharp
FileManagerController fileManager = client.FileManager;
```

### <a name="upload"></a>![Method: ](https://apidocs.io/img/method.png "EasyBimehLanding.Tests.Controllers.FileManagerController.Upload") Upload

> آپلود فایل در ایزی بیمه
> بعد از آپلود، ادرس فایل باید در api های بعدی ارسال شود.


```csharp
Task<Standard.Models.BaseModelUpload> Upload(string subDomain, string xApiKey, string file)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subDomain |  ``` Required ```  | دامنه یا زیر دامنه ی مرکز بیمه |
| xApiKey |  ``` Required ```  | کلید اختصاصی ارتباط با سرور |
| file |  ``` Required ```  | فایل ارسالی |


#### Example Usage

```csharp
string subDomain = "hfz1";
string xApiKey = "d6dfd932-75d8-e911-811a-000c294ecf01";
string file = "file";

Standard.Models.BaseModelUpload result = await fileManager.Upload(subDomain, xApiKey, file);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="liability_doctor_insurance_controller"></a>![Class: ](https://apidocs.io/img/class.png "EasyBimehLanding.Tests.Controllers.LiabilityDoctorInsuranceController") LiabilityDoctorInsuranceController

### Get singleton instance

The singleton instance of the ``` LiabilityDoctorInsuranceController ``` class can be accessed from the API Client.

```csharp
LiabilityDoctorInsuranceController liabilityDoctorInsurance = client.LiabilityDoctorInsurance;
```

### <a name="get_liability_doctor_insurance"></a>![Method: ](https://apidocs.io/img/method.png "EasyBimehLanding.Tests.Controllers.LiabilityDoctorInsuranceController.GetLiabilityDoctorInsurance") GetLiabilityDoctorInsurance

> در یافت اطلاعات اولیه برای استعلام بیمه مسئولیت پزشکان


```csharp
Task<Standard.Models.BaseModelLiabilityDoctorInsurance> GetLiabilityDoctorInsurance(string subDomain, string xApiKey)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subDomain |  ``` Required ```  | دامنه یا زیر دامنه ی مرکز بیمه |
| xApiKey |  ``` Required ```  | کلید اختصاصی ارتباط با سرور |


#### Example Usage

```csharp
string subDomain = "hfz1";
string xApiKey = "d6dfd932-75d8-e911-811a-000c294ecf01";

Standard.Models.BaseModelLiabilityDoctorInsurance result = await liabilityDoctorInsurance.GetLiabilityDoctorInsurance(subDomain, xApiKey);

```


### <a name="get_medical_specialties"></a>![Method: ](https://apidocs.io/img/method.png "EasyBimehLanding.Tests.Controllers.LiabilityDoctorInsuranceController.GetMedicalSpecialties") GetMedicalSpecialties

> دریافت لیست تخصص های پزشکی


```csharp
Task<Standard.Models.BaseModelMedicalSpecialties> GetMedicalSpecialties(string id, string xApiKey)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| id |  ``` Required ```  | نوع تخصص => ParamedicalExpertise => پیراپزشکی MedicalExpertise => پزشکی |
| xApiKey |  ``` Required ```  | کلید اختصاصی ارتباط با سرور |


#### Example Usage

```csharp
string id = "ParamedicalExpertise";
string xApiKey = "d6dfd932-75d8-e911-811a-000c294ecf01";

Standard.Models.BaseModelMedicalSpecialties result = await liabilityDoctorInsurance.GetMedicalSpecialties(id, xApiKey);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="car_body_controller"></a>![Class: ](https://apidocs.io/img/class.png "EasyBimehLanding.Tests.Controllers.CarBodyController") CarBodyController

### Get singleton instance

The singleton instance of the ``` CarBodyController ``` class can be accessed from the API Client.

```csharp
CarBodyController carBody = client.CarBody;
```

### <a name="get_car_brand"></a>![Method: ](https://apidocs.io/img/method.png "EasyBimehLanding.Tests.Controllers.CarBodyController.GetCarBrand") GetCarBrand

> دریافت برند خودرو


```csharp
Task<Standard.Models.CarBrand> GetCarBrand(string xApiKey)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xApiKey |  ``` Required ```  | شناسه ی اختصاصی ارتباط با سرور |


#### Example Usage

```csharp
string xApiKey = "d6dfd932-75d8-e911-811a-000c294ecf01";

Standard.Models.CarBrand result = await carBody.GetCarBrand(xApiKey);

```


### <a name="get_car_brand_tips"></a>![Method: ](https://apidocs.io/img/method.png "EasyBimehLanding.Tests.Controllers.CarBodyController.GetCarBrandTips") GetCarBrandTips

> دریافت لیست تیپ خودرو


```csharp
Task<Standard.Models.CarBrandTips> GetCarBrandTips(int carBrandId, string xApiKey)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| carBrandId |  ``` Required ```  | شناسه ی برند خودرو |
| xApiKey |  ``` Required ```  | کلید اختصاصی ارتباط با سرور |


#### Example Usage

```csharp
int carBrandId = 190;
string xApiKey = "d6dfd932-75d8-e911-811a-000c294ecf01";

Standard.Models.CarBrandTips result = await carBody.GetCarBrandTips(carBrandId, xApiKey);

```


### <a name="get_has_plan"></a>![Method: ](https://apidocs.io/img/method.png "EasyBimehLanding.Tests.Controllers.CarBodyController.GetHasPlan") GetHasPlan

> آیا این نوع بیمه نامه، طرح بیمه ای دارد؟


```csharp
Task<Standard.Models.HasPlan> GetHasPlan(string subDomain, int insurancePolicyType, string xApiKey)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subDomain |  ``` Required ```  | دامنه یا زیر دامنه ی مرکز بیمه |
| insurancePolicyType |  ``` Required ```  | شناسه ی نوع بیمه نامه => بیمه بدنه=2 |
| xApiKey |  ``` Required ```  | کلید اختصاصی ارتباط با سرور |


#### Example Usage

```csharp
string subDomain = "hfz1";
int insurancePolicyType = 2;
string xApiKey = "d6dfd932-75d8-e911-811a-000c294ecf01";

Standard.Models.HasPlan result = await carBody.GetHasPlan(subDomain, insurancePolicyType, xApiKey);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="electronic_equipment_insurance_controller"></a>![Class: ](https://apidocs.io/img/class.png "EasyBimehLanding.Tests.Controllers.ElectronicEquipmentInsuranceController") ElectronicEquipmentInsuranceController

### Get singleton instance

The singleton instance of the ``` ElectronicEquipmentInsuranceController ``` class can be accessed from the API Client.

```csharp
ElectronicEquipmentInsuranceController electronicEquipmentInsurance = client.ElectronicEquipmentInsurance;
```

### <a name="get_electronic_equipment_insurance"></a>![Method: ](https://apidocs.io/img/method.png "EasyBimehLanding.Tests.Controllers.ElectronicEquipmentInsuranceController.GetElectronicEquipmentInsurance") GetElectronicEquipmentInsurance

> دریافت اطلاعات اولیه استعلام بیمه نامه ی تجهیزات الکترونیک


```csharp
Task<Standard.Models.BaseModelElectronicEquipmentInsurance> GetElectronicEquipmentInsurance(string subDomain, string xApiKey)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subDomain |  ``` Required ```  | دامنه یا زیر دامنه ی مرکز بیمه |
| xApiKey |  ``` Required ```  | کلید اختصاصی ارتباط با سرور |


#### Example Usage

```csharp
string subDomain = "subDomain";
string xApiKey = "x-api-key";

Standard.Models.BaseModelElectronicEquipmentInsurance result = await electronicEquipmentInsurance.GetElectronicEquipmentInsurance(subDomain, xApiKey);

```


### <a name="get_device_brand_types"></a>![Method: ](https://apidocs.io/img/method.png "EasyBimehLanding.Tests.Controllers.ElectronicEquipmentInsuranceController.GetDeviceBrandTypes") GetDeviceBrandTypes

> دریافت لیست نوع برند دستگاه


```csharp
Task<Standard.Models.BaseModelDeviceBrandTypes> GetDeviceBrandTypes(int deviceGroup, int deviceTypeId, string xApiKey)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| deviceGroup |  ``` Required ```  | شناسه ی گروه دستگاه |
| deviceTypeId |  ``` Required ```  | شناسه ی نوع دستگاه |
| xApiKey |  ``` Required ```  | کلید اختصاصی ارتباط با سرور |


#### Example Usage

```csharp
int deviceGroup = 1;
int deviceTypeId = 1;
string xApiKey = "d6dfd932-75d8-e911-811a-000c294ecf01";

Standard.Models.BaseModelDeviceBrandTypes result = await electronicEquipmentInsurance.GetDeviceBrandTypes(deviceGroup, deviceTypeId, xApiKey);

```


### <a name="get_divice_franchisee"></a>![Method: ](https://apidocs.io/img/method.png "EasyBimehLanding.Tests.Controllers.ElectronicEquipmentInsuranceController.GetDiviceFranchisee") GetDiviceFranchisee

> دریافت لیست فرانشیر استعلام بیمه نامه ی تجهیزات الکترونیک


```csharp
Task<Standard.Models.BaseModelDiviceFranchisee> GetDiviceFranchisee(int deviceModelId, string xApiKey)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| deviceModelId |  ``` Required ```  | شناسه ی مدل دستگاه |
| xApiKey |  ``` Required ```  | کلید اختصاصی ارتباط با سرور |


#### Example Usage

```csharp
int deviceModelId = 1340;
string xApiKey = "d6dfd932-75d8-e911-811a-000c294ecf01";

Standard.Models.BaseModelDiviceFranchisee result = await electronicEquipmentInsurance.GetDiviceFranchisee(deviceModelId, xApiKey);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="other_insurance_types_controller"></a>![Class: ](https://apidocs.io/img/class.png "EasyBimehLanding.Tests.Controllers.OtherInsuranceTypesController") OtherInsuranceTypesController

### Get singleton instance

The singleton instance of the ``` OtherInsuranceTypesController ``` class can be accessed from the API Client.

```csharp
OtherInsuranceTypesController otherInsuranceTypes = client.OtherInsuranceTypes;
```

### <a name="get_other_insurance_types"></a>![Method: ](https://apidocs.io/img/method.png "EasyBimehLanding.Tests.Controllers.OtherInsuranceTypesController.GetOtherInsuranceTypes") GetOtherInsuranceTypes

> دریافت لیست سایر بیمه نامه ها


```csharp
Task<Standard.Models.OtherInsuranceTypes> GetOtherInsuranceTypes(string subDomain, string xApiKey)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subDomain |  ``` Required ```  | دامنه یا زیر دامنه ی مرکز بیمه |
| xApiKey |  ``` Required ```  | کلید اختصاصی ارتباط با سرور |


#### Example Usage

```csharp
string subDomain = "hfz1";
string xApiKey = "d6dfd932-75d8-e911-811a-000c294ecf01";

Standard.Models.OtherInsuranceTypes result = await otherInsuranceTypes.GetOtherInsuranceTypes(subDomain, xApiKey);

```


### <a name="get_send_sms_token"></a>![Method: ](https://apidocs.io/img/method.png "EasyBimehLanding.Tests.Controllers.OtherInsuranceTypesController.GetSendSmsToken") GetSendSmsToken

> ارسال توکن تایید شماره تماس، برای احراز هویت کاربر


```csharp
Task<Standard.Models.SendSmsToken> GetSendSmsToken(string mobile, string insuranceCentreSubDomain, string xApiKey)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| mobile |  ``` Required ```  | شماره موبایل |
| insuranceCentreSubDomain |  ``` Required ```  | دامنه یا زیردامنه ی مرکز بیمه |
| xApiKey |  ``` Required ```  | کلید اختصاصی ارتباط با سرور |


#### Example Usage

```csharp
string mobile = "09018318086";
string insuranceCentreSubDomain = "hfz1";
string xApiKey = "d6dfd932-75d8-e911-811a-000c294ecf01";

Standard.Models.SendSmsToken result = await otherInsuranceTypes.GetSendSmsToken(mobile, insuranceCentreSubDomain, xApiKey);

```


### <a name="get_verify_sms_token"></a>![Method: ](https://apidocs.io/img/method.png "EasyBimehLanding.Tests.Controllers.OtherInsuranceTypesController.GetVerifySmsToken") GetVerifySmsToken

> تایید توکن پیامک شده به کاربر، برای احراز هویت


```csharp
Task<Standard.Models.Status200> GetVerifySmsToken(
        string mobile,
        int token,
        string insuranceCentreSubDomain,
        string aliasName,
        string resource,
        string xApiKey)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| mobile |  ``` Required ```  | شماره موبایل |
| token |  ``` Required ```  | توکن دریافتی کاربر از پیامک |
| insuranceCentreSubDomain |  ``` Required ```  | دامنه یا زیر دامنه ی اختصاصی مرکز بیمه |
| aliasName |  ``` Required ```  | نام و نام خانوادگی کاربر |
| resource |  ``` Required ```  | دامنه ی درخواست دهنده |
| xApiKey |  ``` Required ```  | کلید اختصاصی ارتباط با سرور |


#### Example Usage

```csharp
string mobile = "09018318086";
int token = 27763;
string insuranceCentreSubDomain = "hfz1";
string aliasName = "علی موسوی";
string resource = "https://hfz1.easybimeh.com";
string xApiKey = "d6dfd932-75d8-e911-811a-000c294ecf01";

Standard.Models.Status200 result = await otherInsuranceTypes.GetVerifySmsToken(mobile, token, insuranceCentreSubDomain, aliasName, resource, xApiKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad Request |


[Back to List of Controllers](#list_of_controllers)

## <a name="third_party_insurance_controller"></a>![Class: ](https://apidocs.io/img/class.png "EasyBimehLanding.Tests.Controllers.ThirdPartyInsuranceController") ThirdPartyInsuranceController

### Get singleton instance

The singleton instance of the ``` ThirdPartyInsuranceController ``` class can be accessed from the API Client.

```csharp
ThirdPartyInsuranceController thirdPartyInsurance = client.ThirdPartyInsurance;
```

### <a name="get_car_brands"></a>![Method: ](https://apidocs.io/img/method.png "EasyBimehLanding.Tests.Controllers.ThirdPartyInsuranceController.GetCarBrands") GetCarBrands

> دریافت لیست برند خودرو ها


```csharp
Task<Standard.Models.CarBrands> GetCarBrands(int carTypeGroup, string xApiKey)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| carTypeGroup |  ``` Required ```  | شناسه ی گروه خودرو |
| xApiKey |  ``` Required ```  | کلید اختصاصی ارتباط با سرور |


#### Example Usage

```csharp
int carTypeGroup = 1;
string xApiKey = "d6dfd932-75d8-e911-811a-000c294ecf01";

Standard.Models.CarBrands result = await thirdPartyInsurance.GetCarBrands(carTypeGroup, xApiKey);

```


### <a name="get_risk_level"></a>![Method: ](https://apidocs.io/img/method.png "EasyBimehLanding.Tests.Controllers.ThirdPartyInsuranceController.GetRiskLevel") GetRiskLevel

> دریافت لیست تخفیف های بیمه


```csharp
Task<Standard.Models.RiskLevel> GetRiskLevel(int insurancePolicyType, string xApiKey)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| insurancePolicyType |  ``` Required ```  | شناسه ی نوع بیمه نامه |
| xApiKey |  ``` Required ```  | کلید اختصاصی ارتباط با سرور |


#### Example Usage

```csharp
int insurancePolicyType = 0;
string xApiKey = "d6dfd932-75d8-e911-811a-000c294ecf01";

Standard.Models.RiskLevel result = await thirdPartyInsurance.GetRiskLevel(insurancePolicyType, xApiKey);

```


### <a name="get_car_brand_tips"></a>![Method: ](https://apidocs.io/img/method.png "EasyBimehLanding.Tests.Controllers.ThirdPartyInsuranceController.GetCarBrandTips") GetCarBrandTips

> دریافت لیست تیپ خودرو


```csharp
Task<Standard.Models.CarBrandTips> GetCarBrandTips(int carBrandId, string xApiKey)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| carBrandId |  ``` Required ```  | شناسه ی برند خودرو |
| xApiKey |  ``` Required ```  | کلید اختصاصی ارتباط با سرور |


#### Example Usage

```csharp
int carBrandId = 190;
string xApiKey = "d6dfd932-75d8-e911-811a-000c294ecf01";

Standard.Models.CarBrandTips result = await thirdPartyInsurance.GetCarBrandTips(carBrandId, xApiKey);

```


### <a name="get_car_uses"></a>![Method: ](https://apidocs.io/img/method.png "EasyBimehLanding.Tests.Controllers.ThirdPartyInsuranceController.GetCarUses") GetCarUses

> دریافت لیست نوع کاربری خودرو


```csharp
Task<Standard.Models.CarUses> GetCarUses(int carTypeId, string xApiKey)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| carTypeId |  ``` Required ```  | شناسه ی نوع خودرو |
| xApiKey |  ``` Required ```  | کلید اختصاصی ارتباط با سرور |


#### Example Usage

```csharp
int carTypeId = 103;
string xApiKey = "d6dfd932-75d8-e911-811a-000c294ecf01";

Standard.Models.CarUses result = await thirdPartyInsurance.GetCarUses(carTypeId, xApiKey);

```


### <a name="get_has_plan"></a>![Method: ](https://apidocs.io/img/method.png "EasyBimehLanding.Tests.Controllers.ThirdPartyInsuranceController.GetHasPlan") GetHasPlan

> آیا این نوع بیمه نامه، طرح بیمه ای دارد؟


```csharp
Task<Standard.Models.HasPlan> GetHasPlan(string subDomain, int insurancePolicyType, string xApiKey)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subDomain |  ``` Required ```  | دامنه یا زیر دامنه ی مرکز بیمه |
| insurancePolicyType |  ``` Required ```  | شناسه ی نوع بیمه |
| xApiKey |  ``` Required ```  | کلید اختصاصی ارتباط با سرور |


#### Example Usage

```csharp
string subDomain = "hfz1";
int insurancePolicyType = 0;
string xApiKey = "d6dfd932-75d8-e911-811a-000c294ecf01";

Standard.Models.HasPlan result = await thirdPartyInsurance.GetHasPlan(subDomain, insurancePolicyType, xApiKey);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="motorcycle_insurance_controller"></a>![Class: ](https://apidocs.io/img/class.png "EasyBimehLanding.Tests.Controllers.MotorcycleInsuranceController") MotorcycleInsuranceController

### Get singleton instance

The singleton instance of the ``` MotorcycleInsuranceController ``` class can be accessed from the API Client.

```csharp
MotorcycleInsuranceController motorcycleInsurance = client.MotorcycleInsurance;
```

### <a name="get_car_brands"></a>![Method: ](https://apidocs.io/img/method.png "EasyBimehLanding.Tests.Controllers.MotorcycleInsuranceController.GetCarBrands") GetCarBrands

> دریافت لیست برند موتور سیکلت


```csharp
Task<Standard.Models.CarBrands> GetCarBrands(int carTypeGroup, string xApiKey)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| carTypeGroup |  ``` Required ```  | شناسه ی گروه خودرویی، موتور سیکلت =>0 |
| xApiKey |  ``` Required ```  | کلید اختصاصی ارتباط با سرور |


#### Example Usage

```csharp
int carTypeGroup = 0;
string xApiKey = "d6dfd932-75d8-e911-811a-000c294ecf01";

Standard.Models.CarBrands result = await motorcycleInsurance.GetCarBrands(carTypeGroup, xApiKey);

```


### <a name="get_car_brand_tips"></a>![Method: ](https://apidocs.io/img/method.png "EasyBimehLanding.Tests.Controllers.MotorcycleInsuranceController.GetCarBrandTips") GetCarBrandTips

> دریافت لیست تیپ موتور سیکلت


```csharp
Task<Standard.Models.CarBrandTips> GetCarBrandTips(int carBrandId, string xApiKey)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| carBrandId |  ``` Required ```  | شناسه ی برند موتور سیکلت |
| xApiKey |  ``` Required ```  | کلید اختصاصی ارتباط با سرور |


#### Example Usage

```csharp
int carBrandId = 472;
string xApiKey = "d6dfd932-75d8-e911-811a-000c294ecf01";

Standard.Models.CarBrandTips result = await motorcycleInsurance.GetCarBrandTips(carBrandId, xApiKey);

```


### <a name="get_has_plan"></a>![Method: ](https://apidocs.io/img/method.png "EasyBimehLanding.Tests.Controllers.MotorcycleInsuranceController.GetHasPlan") GetHasPlan

> آیا این نوع بیمه نامه، طرح بیمه ای دارد؟


```csharp
Task<Standard.Models.HasPlan> GetHasPlan(string subDomain, int insurancePolicyType, string xApiKey)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subDomain |  ``` Required ```  | دامنه یا زیر دامنه ی مرکز بیمه |
| insurancePolicyType |  ``` Required ```  | شناسه ی نوع بیمه نامه |
| xApiKey |  ``` Required ```  | کلید اختصاصی ارتباط با سرور |


#### Example Usage

```csharp
string subDomain = "hfz1";
int insurancePolicyType = 7;
string xApiKey = "d6dfd932-75d8-e911-811a-000c294ecf01";

Standard.Models.HasPlan result = await motorcycleInsurance.GetHasPlan(subDomain, insurancePolicyType, xApiKey);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="fire_insurance_controller"></a>![Class: ](https://apidocs.io/img/class.png "EasyBimehLanding.Tests.Controllers.FireInsuranceController") FireInsuranceController

### Get singleton instance

The singleton instance of the ``` FireInsuranceController ``` class can be accessed from the API Client.

```csharp
FireInsuranceController fireInsurance = client.FireInsurance;
```

### <a name="get_fire_insurance"></a>![Method: ](https://apidocs.io/img/method.png "EasyBimehLanding.Tests.Controllers.FireInsuranceController.GetFireInsurance") GetFireInsurance

> دریافت اطلاعات پایه بیمه ی آتش سوزی


```csharp
Task<Standard.Models.BaseModelFireInsurance> GetFireInsurance(string subDomain, int insurancePolicyId, string xApiKey)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subDomain |  ``` Required ```  | دامنه یا زیر دامنه ی مرکز بیمه |
| insurancePolicyId |  ``` Required ```  | شناسه ی بیمه نامه |
| xApiKey |  ``` Required ```  | کلید اختصاصی ارتباط با سرور |


#### Example Usage

```csharp
string subDomain = "hfz1";
int insurancePolicyId = 0;
string xApiKey = "d6dfd932-75d8-e911-811a-000c294ecf01";

Standard.Models.BaseModelFireInsurance result = await fireInsurance.GetFireInsurance(subDomain, insurancePolicyId, xApiKey);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="earthquake_insurance_controller"></a>![Class: ](https://apidocs.io/img/class.png "EasyBimehLanding.Tests.Controllers.EarthquakeInsuranceController") EarthquakeInsuranceController

### Get singleton instance

The singleton instance of the ``` EarthquakeInsuranceController ``` class can be accessed from the API Client.

```csharp
EarthquakeInsuranceController earthquakeInsurance = client.EarthquakeInsurance;
```

### <a name="get_earthquake"></a>![Method: ](https://apidocs.io/img/method.png "EasyBimehLanding.Tests.Controllers.EarthquakeInsuranceController.GetEarthquake") GetEarthquake

> دریافت اطلاعات پایه ی بیمه ی زلزله


```csharp
Task<Standard.Models.BaseModelEarthquake> GetEarthquake(
        string subDomain,
        int insurancePolicyId,
        int insurancePolicyType,
        string xApiKey)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subDomain |  ``` Required ```  | دامنه یا زیر دامنه ی مرکز بیمه |
| insurancePolicyId |  ``` Required ```  | شناسه ی بیمه نامه |
| insurancePolicyType |  ``` Required ```  | شناسه ی نوع بیمه نامه |
| xApiKey |  ``` Required ```  | کلید اختصاصی ارتباط با سرور |


#### Example Usage

```csharp
string subDomain = "hfz1";
int insurancePolicyId = 0;
int insurancePolicyType = 6;
string xApiKey = "d6dfd932-75d8-e911-811a-000c294ecf01";

Standard.Models.BaseModelEarthquake result = await earthquakeInsurance.GetEarthquake(subDomain, insurancePolicyId, insurancePolicyType, xApiKey);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="travel_insurance_controller"></a>![Class: ](https://apidocs.io/img/class.png "EasyBimehLanding.Tests.Controllers.TravelInsuranceController") TravelInsuranceController

### Get singleton instance

The singleton instance of the ``` TravelInsuranceController ``` class can be accessed from the API Client.

```csharp
TravelInsuranceController travelInsurance = client.TravelInsurance;
```

### <a name="get_travel_insurance"></a>![Method: ](https://apidocs.io/img/method.png "EasyBimehLanding.Tests.Controllers.TravelInsuranceController.GetTravelInsurance") GetTravelInsurance

> TODO: Add Description


```csharp
Task<Standard.Models.BaseModelTravelInsurance> GetTravelInsurance(string subDomain, int insurancePolicyId, string xApiKey)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subDomain |  ``` Required ```  | دامنه یا زیر دامنه ی مرکز بیمه |
| insurancePolicyId |  ``` Required ```  | شناسه ی بیمه نامه |
| xApiKey |  ``` Required ```  | کلید اختصاصی ارتباط با سرور |


#### Example Usage

```csharp
string subDomain = "hfz1";
int insurancePolicyId = 0;
string xApiKey = "d6dfd932-75d8-e911-811a-000c294ecf01";

Standard.Models.BaseModelTravelInsurance result = await travelInsurance.GetTravelInsurance(subDomain, insurancePolicyId, xApiKey);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="elevator_insurance_controller"></a>![Class: ](https://apidocs.io/img/class.png "EasyBimehLanding.Tests.Controllers.ElevatorInsuranceController") ElevatorInsuranceController

### Get singleton instance

The singleton instance of the ``` ElevatorInsuranceController ``` class can be accessed from the API Client.

```csharp
ElevatorInsuranceController elevatorInsurance = client.ElevatorInsurance;
```

### <a name="get_elevator_insurance"></a>![Method: ](https://apidocs.io/img/method.png "EasyBimehLanding.Tests.Controllers.ElevatorInsuranceController.GetElevatorInsurance") GetElevatorInsurance

> دریافت اطلاعات پایه ی بیمه نامه ی آسانسور


```csharp
Task<Standard.Models.BaseModelElevatorInsurance> GetElevatorInsurance(string subDomain, int insurancePolicyId, string xApiKey)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subDomain |  ``` Required ```  | دامنه یا زیر دامنه ی مرکز بیمه |
| insurancePolicyId |  ``` Required ```  | شناسه ی بیمه نامه |
| xApiKey |  ``` Required ```  | کلید اختصاصی ارتباط با سرور |


#### Example Usage

```csharp
string subDomain = "hfz1";
int insurancePolicyId = 0;
string xApiKey = "d6dfd932-75d8-e911-811a-000c294ecf01";

Standard.Models.BaseModelElevatorInsurance result = await elevatorInsurance.GetElevatorInsurance(subDomain, insurancePolicyId, xApiKey);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="main_controller"></a>![Class: ](https://apidocs.io/img/class.png "EasyBimehLanding.Tests.Controllers.MainController") MainController

### Get singleton instance

The singleton instance of the ``` MainController ``` class can be accessed from the API Client.

```csharp
MainController main = client.Main;
```

### <a name="get_portal_landing_page"></a>![Method: ](https://apidocs.io/img/method.png "EasyBimehLanding.Tests.Controllers.MainController.GetPortalLandingPage") GetPortalLandingPage

> در یافت اطلاعات لندینگ مراکز بیمه


```csharp
Task<Standard.Models.BaseModelPortalLandingPage> GetPortalLandingPage(string id, string xApiKey)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| id |  ``` Required ```  | دامنه یا زیر دامنه ی مرکز بیمه |
| xApiKey |  ``` Required ```  | کلید اختصاصی ارتباط با سرور |


#### Example Usage

```csharp
string id = "hfz1";
string xApiKey = "d6dfd932-75d8-e911-811a-000c294ecf01";

Standard.Models.BaseModelPortalLandingPage result = await main.GetPortalLandingPage(id, xApiKey);

```


### <a name="get_insurance_centre_policy_types"></a>![Method: ](https://apidocs.io/img/method.png "EasyBimehLanding.Tests.Controllers.MainController.GetInsuranceCentrePolicyTypes") GetInsuranceCentrePolicyTypes

> دریافت لیست بیمه ی های ارائه شده توسط مرکز بیمه


```csharp
Task<Standard.Models.BaseModelInsuranceCentrePolicyTypes> GetInsuranceCentrePolicyTypes(string subDomain, string xApiKey)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subDomain |  ``` Required ```  | دامنه یا زیر دامنه ی مرکز بیمه |
| xApiKey |  ``` Required ```  | کلید اختصاصی ارتباط با سرور |


#### Example Usage

```csharp
string subDomain = "hfz1";
string xApiKey = "d6dfd932-75d8-e911-811a-000c294ecf01";

Standard.Models.BaseModelInsuranceCentrePolicyTypes result = await main.GetInsuranceCentrePolicyTypes(subDomain, xApiKey);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="combo_data_controller"></a>![Class: ](https://apidocs.io/img/class.png "EasyBimehLanding.Tests.Controllers.ComboDataController") ComboDataController

### Get singleton instance

The singleton instance of the ``` ComboDataController ``` class can be accessed from the API Client.

```csharp
ComboDataController comboData = client.ComboData;
```

### <a name="get_damage_type"></a>![Method: ](https://apidocs.io/img/method.png "EasyBimehLanding.Tests.Controllers.ComboDataController.GetDamageType") GetDamageType

> دریافت لیست نوع خسارت


```csharp
Task<Standard.Models.BaseModelDamageType> GetDamageType(string xApiKey)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xApiKey |  ``` Required ```  | کلید اختصاصی ارتباط با سرور |


#### Example Usage

```csharp
string xApiKey = "d6dfd932-75d8-e911-811a-000c294ecf01";

Standard.Models.BaseModelDamageType result = await comboData.GetDamageType(xApiKey);

```


### <a name="get_insurance_types"></a>![Method: ](https://apidocs.io/img/method.png "EasyBimehLanding.Tests.Controllers.ComboDataController.GetInsuranceTypes") GetInsuranceTypes

> دریافت لیست نوع بیمه نامه


```csharp
Task<Standard.Models.InsuranceTypes> GetInsuranceTypes(string subDomain, bool issueInsurance, string xApiKey)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subDomain |  ``` Required ```  | دامنه یا زیر دامنه ی مرکز بیمه |
| issueInsurance |  ``` Required ```  | دریافت بیمه نامه های قابل صدور |
| xApiKey |  ``` Required ```  | کلید اختصاصی ارتباط با سرور |


#### Example Usage

```csharp
string subDomain = "hfz1";
bool issueInsurance = false;
string xApiKey = "d6dfd932-75d8-e911-811a-000c294ecf01";

Standard.Models.InsuranceTypes result = await comboData.GetInsuranceTypes(subDomain, issueInsurance, xApiKey);

```


### <a name="get_insurance_companies"></a>![Method: ](https://apidocs.io/img/method.png "EasyBimehLanding.Tests.Controllers.ComboDataController.GetInsuranceCompanies") GetInsuranceCompanies

> دریافت لیست شرکت های بیمه


```csharp
Task<Standard.Models.InsuranceCompanies> GetInsuranceCompanies(string subDomain, int insuranceTypeId, string xApiKey)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subDomain |  ``` Required ```  | دامنه یا زیر دامنه ی مرکز بیمه |
| insuranceTypeId |  ``` Required ```  | شناسه ی نوع بیمه نامه |
| xApiKey |  ``` Required ```  | کلید اختصاصی ارتباط با سرور |


#### Example Usage

```csharp
string subDomain = "hfz1";
int insuranceTypeId = 1;
string xApiKey = "d6dfd932-75d8-e911-811a-000c294ecf01";

Standard.Models.InsuranceCompanies result = await comboData.GetInsuranceCompanies(subDomain, insuranceTypeId, xApiKey);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="tracking_damage_controller"></a>![Class: ](https://apidocs.io/img/class.png "EasyBimehLanding.Tests.Controllers.TrackingDamageController") TrackingDamageController

### Get singleton instance

The singleton instance of the ``` TrackingDamageController ``` class can be accessed from the API Client.

```csharp
TrackingDamageController trackingDamage = client.TrackingDamage;
```

### <a name="get_tracking_code"></a>![Method: ](https://apidocs.io/img/method.png "EasyBimehLanding.Tests.Controllers.TrackingDamageController.GetTrackingCode") GetTrackingCode

> استعلام وضعیت خسارت


```csharp
Task<Standard.Models.BaseModelTrakingCode> GetTrackingCode(string mTrackingCode, string xApiKey)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| mTrackingCode |  ``` Required ```  | کد پیگیری خسارت |
| xApiKey |  ``` Required ```  | کلید اختصاصی ارتباط با سرور |


#### Example Usage

```csharp
string mTrackingCode = "/{TrackingCode}";
string xApiKey = "d6dfd932-75d8-e911-811a-000c294ecf01";

Standard.Models.BaseModelTrakingCode result = await trackingDamage.GetTrackingCode(mTrackingCode, xApiKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad Request |


### <a name="create_tracking_damage"></a>![Method: ](https://apidocs.io/img/method.png "EasyBimehLanding.Tests.Controllers.TrackingDamageController.CreateTrackingDamage") CreateTrackingDamage

> ثبت خسارت بیمه


```csharp
Task<Standard.Models.TrackingDamage> CreateTrackingDamage(Standard.Models.TrackingDamageRequest body, string xApiKey, string contentType)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | اطلاعات خسارت |
| xApiKey |  ``` Required ```  | کلید اختصاصی ارتباط با سرور |
| contentType |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string bodyValue = "{\r\n  \"personalityType\": 0,\r\n  \"trackingDamageStatus\": [\r\n    {\r\n      \"trackingDamageFile\": [\r\n        {\r\n          \"id\": 162747,\r\n          \"url\": \"https://media.easybimeh.com//Easybimeh/FileManager/InsuranceCentre/hfz1/637089119345134776.jpeg\",\r\n          \"title\": \"کارت شناسایی\"\r\n        }\r\n      ]\r\n    }\r\n  ],\r\n  \"description\": \"بدنه ی خودرو خسارت دیده\",\r\n  \"insuranceTypeId\": 1,\r\n  \"insuranceCompanyId\": 34,\r\n  \"insurancePolicyNumber\": \"123456\",\r\n  \"damageType\": \"مالی\",\r\n  \"name\": \"کاظم\",\r\n  \"nationalCode\": \"3080118383\",\r\n  \"mobile\": \"09018318086\",\r\n  \"insuredProfile\": \"پژو 405\",\r\n  \"subDomain\": \"hfz1\"\r\n}";
var body = Newtonsoft.Json.JsonConvert.DeserializeObject<Standard.Models.TrackingDamageRequest>(bodyValue);
string xApiKey = "d6dfd932-75d8-e911-811a-000c294ecf01";
string contentType = "application/json";

Standard.Models.TrackingDamage result = await trackingDamage.CreateTrackingDamage(body, xApiKey, contentType);

```


### <a name="get_status_status_collections"></a>![Method: ](https://apidocs.io/img/method.png "EasyBimehLanding.Tests.Controllers.TrackingDamageController.GetStatusStatusCollections") GetStatusStatusCollections

> دریافت لیست وضعیت های خسارت


```csharp
Task<Standard.Models.BaseModelStatusStatusCollections> GetStatusStatusCollections(int statusType, string xApiKey)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| statusType |  ``` Required ```  | نوع وضعیت ها ی خسارت => 0 |
| xApiKey |  ``` Required ```  | کلید اختصاصی ارتباط با سرور |


#### Example Usage

```csharp
int statusType = 0;
string xApiKey = "d6dfd932-75d8-e911-811a-000c294ecf01";

Standard.Models.BaseModelStatusStatusCollections result = await trackingDamage.GetStatusStatusCollections(statusType, xApiKey);

```


### <a name="get_status"></a>![Method: ](https://apidocs.io/img/method.png "EasyBimehLanding.Tests.Controllers.TrackingDamageController.GetStatus") GetStatus

> دریافت اطلاعات وضعیت


```csharp
Task<Standard.Models.BaseModelStatus> GetStatus(int entityId, string xApiKey)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| entityId |  ``` Required ```  | شناسه ی وضعیت |
| xApiKey |  ``` Required ```  | کلید اختصاصی ارتباط با سرور |


#### Example Usage

```csharp
int entityId = 1129;
string xApiKey = "d6dfd932-75d8-e911-811a-000c294ecf01";

Standard.Models.BaseModelStatus result = await trackingDamage.GetStatus(entityId, xApiKey);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="footer_controller"></a>![Class: ](https://apidocs.io/img/class.png "EasyBimehLanding.Tests.Controllers.FooterController") FooterController

### Get singleton instance

The singleton instance of the ``` FooterController ``` class can be accessed from the API Client.

```csharp
FooterController footer = client.Footer;
```

### <a name="get_portal_landing_contact_about"></a>![Method: ](https://apidocs.io/img/method.png "EasyBimehLanding.Tests.Controllers.FooterController.GetPortalLandingContactAbout") GetPortalLandingContactAbout

> دریافت اطلاعات درباره ی ما


```csharp
Task<Standard.Models.BaseModelPortalLandingContactAbout> GetPortalLandingContactAbout(string xApiKey)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xApiKey |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string xApiKey = "d6dfd932-75d8-e911-811a-000c294ecf01";

Standard.Models.BaseModelPortalLandingContactAbout result = await footer.GetPortalLandingContactAbout(xApiKey);

```


### <a name="get_faq_insurance_centre"></a>![Method: ](https://apidocs.io/img/method.png "EasyBimehLanding.Tests.Controllers.FooterController.GetFaqInsuranceCentre") GetFaqInsuranceCentre

> دریافت لیست سوالات متداول


```csharp
Task<Standard.Models.BaseModelFaqInsuranceCentre> GetFaqInsuranceCentre(string xApiKey)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| xApiKey |  ``` Required ```  | کلید اختصاصی ارتباط با سرور |


#### Example Usage

```csharp
string xApiKey = "d6dfd932-75d8-e911-811a-000c294ecf01";

Standard.Models.BaseModelFaqInsuranceCentre result = await footer.GetFaqInsuranceCentre(xApiKey);

```


### <a name="get_insurance_policy_tracking"></a>![Method: ](https://apidocs.io/img/method.png "EasyBimehLanding.Tests.Controllers.FooterController.GetInsurancePolicyTracking") GetInsurancePolicyTracking

> پیگیری وضعیت بیمه نامه


```csharp
Task<Standard.Models.BaseModelInsurancePolicyTracking> GetInsurancePolicyTracking(int trackingCode, long nationalCode, string xApiKey)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| trackingCode |  ``` Required ```  | شماره ی پیگیری بیمه نامه |
| nationalCode |  ``` Required ```  | کد ملی کاربر |
| xApiKey |  ``` Required ```  | کلید اختصاصی ارتباط با سرور |


#### Example Usage

```csharp
int trackingCode = 213981083;
long nationalCode = 3080115309L;
string xApiKey = "d6dfd932-75d8-e911-811a-000c294ecf01";

Standard.Models.BaseModelInsurancePolicyTracking result = await footer.GetInsurancePolicyTracking(trackingCode, nationalCode, xApiKey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 500 | Internal Server Error |


[Back to List of Controllers](#list_of_controllers)

## <a name="insurance_policy_plan_controller"></a>![Class: ](https://apidocs.io/img/class.png "EasyBimehLanding.Tests.Controllers.InsurancePolicyPlanController") InsurancePolicyPlanController

### Get singleton instance

The singleton instance of the ``` InsurancePolicyPlanController ``` class can be accessed from the API Client.

```csharp
InsurancePolicyPlanController insurancePolicyPlan = client.InsurancePolicyPlan;
```

### <a name="get_special_plan"></a>![Method: ](https://apidocs.io/img/method.png "EasyBimehLanding.Tests.Controllers.InsurancePolicyPlanController.GetSpecialPlan") GetSpecialPlan

> دریافت لیست طرح های بیمه ای


```csharp
Task<Standard.Models.BaseModelSpecialPlan> GetSpecialPlan(string subDomain, string xApiKey)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subDomain |  ``` Required ```  | دامنه یا زیر دامنه ی مرکز بیمه |
| xApiKey |  ``` Required ```  | کلید اختصاصی ارتباط با سرور |


#### Example Usage

```csharp
string subDomain = "hfz1";
string xApiKey = "d6dfd932-75d8-e911-811a-000c294ecf01";

Standard.Models.BaseModelSpecialPlan result = await insurancePolicyPlan.GetSpecialPlan(subDomain, xApiKey);

```


[Back to List of Controllers](#list_of_controllers)



