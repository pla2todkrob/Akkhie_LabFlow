# Akkhie LabFlow - โปรแกรมบันทึกผลวิเคราะห์ของเสีย

## ภาพรวม (Overview)

**LabFlow** เป็นแอปพลิเคชันสำหรับ Windows (Windows Forms) ที่พัฒนาขึ้นเพื่อใช้ในการบันทึกและจัดการข้อมูลผลการวิเคราะห์ของเสียในห้องปฏิบัติการ (Lab) โปรแกรมนี้ช่วยให้ผู้ใช้สามารถค้นหาข้อมูลของเสียที่มีอยู่, เพิ่มผลการวิเคราะห์ใหม่, หรืออัปเดตข้อมูลเดิมได้อย่างสะดวกและรวดเร็ว โดยเชื่อมต่อกับฐานข้อมูล SQL Server เพื่อจัดเก็บข้อมูลอย่างเป็นระบบ

## คุณสมบัติหลัก (Features)

- **ค้นหาข้อมูล:** ค้นหาข้อมูลของเสียด้วย "เลขที่ของเสีย" (Waste No.)
- **แสดงผล:** แสดงผลการวิเคราะห์ที่มีอยู่แล้วในฐานข้อมูล
- **เพิ่มข้อมูลใหม่:** หากไม่พบข้อมูลผลวิเคราะห์เดิม สามารถกรอกข้อมูลใหม่ได้ทันที
- **แก้ไขข้อมูล:** แก้ไขและอัปเดตข้อมูลผลวิเคราะห์ที่มีอยู่แล้ว
- **บันทึกข้อมูล:** บันทึกข้อมูลใหม่หรือข้อมูลที่แก้ไขลงในฐานข้อมูล SQL Server
- **ล้างฟอร์ม:** เคลียร์ข้อมูลทั้งหมดบนหน้าจอเพื่อเตรียมรับข้อมูลใหม่

## เทคโนโลยีที่ใช้ (Technology Stack)

- **ภาษา:** C#
- **Framework:** .NET Framework 4.8
- **UI:** Windows Forms
- **Database:** Microsoft SQL Server

## การติดตั้งและใช้งาน (Setup & Usage)

### 1. การตั้งค่าฐานข้อมูล (Database Setup)

โปรแกรมนี้ต้องการการเชื่อมต่อกับฐานข้อมูล SQL Server ที่มีตารางตามโครงสร้างด้านล่างนี้:

**ตาราง `tbWasteDataCR`**
ใช้สำหรับเก็บข้อมูลหลักของของเสีย

| Column      | Data Type | Constraints | Description      |
|-------------|-----------|-------------|------------------|
| `WasteDataID` | `int`     | Primary Key | รหัสอ้างอิงของเสีย |
| `WasteNo`     | `varchar` |             | เลขที่ของเสีย      |

**ตาราง `tbWasteDataLab`**
ใช้สำหรับเก็บผลการวิเคราะห์ของเสีย

| Column            | Data Type | Description                  |
|-------------------|-----------|------------------------------|
| `WasteDataID`     | `int`     | รหัสอ้างอิงของเสีย (Foreign Key) |
| `AnalysisNo`      | `varchar` | เลขที่วิเคราะห์                |
| `SamplingBy`      | `nvarchar`| ผู้เก็บตัวอย่าง               |
| `SamplingByNo`    | `nvarchar`| เลขที่ใบอนุญาตผู้เก็บตัวอย่าง  |
| `FreeChlorine`    | `char(1)` | ผลทดสอบคลอรีน ('Y' หรือ 'N')  |
| `Nitrite`         | `char(1)` | ผลทดสอบไนไตรท์ ('Y' หรือ 'N') |
| `Cyanide`         | `char(1)` | ผลทดสอบไซยาไนด์ ('Y' หรือ 'N')|
| `Physicalstate`   | `nvarchar`| สถานะทางกายภาพ               |
| `Viscosity`       | `nvarchar`| ความหนืด                     |
| `Bulkdensity`     | `nvarchar`| ความหนาแน่น                   |
| `HeatingValue`    | `nvarchar`| ค่าความร้อน (GCV)             |
| `NCVValue`        | `nvarchar`| ค่าความร้อน (NCV)             |
| `MoistureContent` | `nvarchar`| ค่าความชื้น                   |
| `WaterContent`    | `nvarchar`| ปริมาณน้ำ                     |
| `AshContent`      | `nvarchar`| ปริมาณเถ้า                    |
| `CL`              | `nvarchar`| คลอรีน                       |
| `F`               | `nvarchar`| ฟลูออรีน                     |
| `S`               | `nvarchar`| ซัลเฟอร์                     |
| `SludgeContent`   | `nvarchar`| ปริมาณสลัดจ์                 |
| `SolidContent`    | `nvarchar`| ปริมาณของแข็ง                 |
| `NitrogenContent` | `nvarchar`| ไนโตรเจน                     |
| `DrybasisContent` | `nvarchar`| Dry basis                    |
| `HeavyAs`         | `nvarchar`| อะเซนิก (As)                 |
| `HeavyCd`         | `nvarchar`| แคดเมียม (Cd)                 |
| `HeavyCr`         | `nvarchar`| โครเมียม (Cr)                |
| `HeavyHg`         | `nvarchar`| ปรอท (Hg)                     |
| `HeavyPb`         | `nvarchar`| ตะกั่ว (Pb)                   |
| `SS`              | `nvarchar`| Suspended solids             |
| `Acidity`         | `nvarchar`| Acidity                      |
| `Alkalinity`      | `nvarchar`| Alkalinity                   |
| `TDS`             | `nvarchar`| TDS                          |
| `Ni`              | `nvarchar`| นิเกิล (Ni)                   |
| `Mn`              | `nvarchar`| แมงกานีส (Mn)                 |
| `Zn`              | `nvarchar`| สังกะสี (Zn)                  |
| `Cu`              | `nvarchar`| ทองแดง (Cu)                  |
| `HeavyFe`         | `nvarchar`| เหล็ก (Fe)                    |
| `Concentrate`     | `nvarchar`| ความเข้มข้นกรด/ด่าง           |

### 2. การตั้งค่า Connection String

เพื่อความปลอดภัย ควรย้าย Connection String ออกจากซอร์สโค้ดและเก็บไว้ในไฟล์ `App.config`

1.  เปิดไฟล์ `App.config`
2.  เพิ่มส่วน `<connectionStrings>` ภายใน `<configuration>` ดังนี้:
    ```xml
    <configuration>
      <connectionStrings>
        <add name="DBConnection" 
             connectionString="Server=YOUR_SERVER_IP;Database=YOUR_DATABASE;User Id=YOUR_USERNAME;Password=YOUR_PASSWORD;" 
             providerName="System.Data.SqlClient" />
      </connectionStrings>
      ...
    </configuration>
    ```
3.  แก้ไขไฟล์ `DataModels.cs` เพื่ออ่านค่า Connection String จาก `App.config`
    * **ก่อนแก้ไข:**
        ```csharp
        private static readonly string connectionString = "Server=58.82.140.99;Database=BWG_AWSDB;User Id=sa;Password=Akkhie06;";
        ```
    * **หลังแก้ไข:**
        ```csharp
        using System.Configuration;
        // ...
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
        ```
    * **หมายเหตุ:** คุณจะต้องเพิ่ม Reference ไปยัง `System.Configuration` ในโปรเจกต์ด้วย (คลิกขวาที่ References > Add Reference... > Assemblies > Framework > เลือก System.Configuration)

### 3. วิธีการใช้งานโปรแกรม

1.  **เปิดโปรแกรม:** รันไฟล์ `LabFlow.exe`
2.  **ค้นหาข้อมูล:**
    * ป้อน "เลขที่ของเสีย" (Waste No) ที่ต้องการในช่องด้านบน
    * คลิกปุ่ม **"ค้นหา"**
3.  **กรอก/แก้ไขข้อมูล:**
    * หากพบข้อมูลเดิม ระบบจะแสดงข้อมูลนั้นขึ้นมาให้แก้ไข
    * หากไม่พบข้อมูลเดิม แต่มี Waste No อยู่ในระบบ ฟอร์มจะถูกเปิดใช้งานเพื่อให้กรอกข้อมูลใหม่
    * กรอกข้อมูลผลการวิเคราะห์ในช่องต่างๆ ให้ครบถ้วน
4.  **บันทึกข้อมูล:**
    * เมื่อกรอกข้อมูลเสร็จสิ้น คลิกปุ่ม **"บันทึกข้อมูล"**
    * จะมีกล่องข้อความขึ้นมาเพื่อยืนยันการบันทึก
5.  **ล้างข้อมูล:**
    * คลิกปุ่ม **"ล้างข้อมูล"** เพื่อเคลียร์ข้อมูลทั้งหมดบนฟอร์ม และเริ่มต้นการค้นหาใหม่

## โครงสร้างโปรเจกต์ (Project Structure)

-   `LabFlow.sln`: Solution file สำหรับเปิดโปรเจกต์ใน Visual Studio
-   `LabFlow/`: โฟลเดอร์หลักของโปรเจกต์
    -   `MainForm.cs`: โค้ดหลักสำหรับหน้าจอโปรแกรม (UI Logic)
    -   `MainForm.Designer.cs`: โค้ดที่ถูกสร้างโดยอัตโนมัติสำหรับออกแบบหน้าจอ
    -   `DataModels.cs`: ประกอบด้วย
        -   `WasteDataLabModel`: คลาสสำหรับเก็บข้อมูลผลวิเคราะห์
        -   `DatabaseHelper`: คลาสสำหรับจัดการการเชื่อมต่อและคำสั่ง SQL กับฐานข้อมูล
    -   `Program.cs`: จุดเริ่มต้นการทำงานของโปรแกรม
    -   `App.config`: ไฟล์สำหรับตั้งค่าต่างๆ ของโปรแกรม (เช่น Connection String)
    -   `Properties/`: โฟลเดอร์เก็บข้อมูลของโปรเจกต์ เช่น Assembly Info, Resources, Settings

## ข้อเสนอแนะสำหรับการพัฒนาต่อ (Future Improvements)

-   [ ] **Input Validation:** เพิ่มการตรวจสอบข้อมูลที่ผู้ใช้กรอก เช่น ตรวจสอบว่าค่าที่ต้องเป็นตัวเลข (Numeric) ไม่ได้ถูกกรอกด้วยตัวอักษร เพื่อป้องกันข้อผิดพลาดในการบันทึกข้อมูล
-   [ ] **Data Mapping Correction:** แก้ไขการดึงข้อมูล `TDS` และ `Cu` ในเมธอด `GetWasteDataLab` และ `GetUpdateQuery` ในไฟล์ `DataModels.cs` ให้ถูกต้อง
-   [ ] **Error Handling:** ปรับปรุงการจัดการข้อผิดพลาดให้ละเอียดมากขึ้น เช่น แจ้งผู้ใช้เมื่อการเชื่อมต่อฐานข้อมูลล้มเหลวด้วยสาเหตุที่เฉพาะเจาะจง
-   [ ] **UI/UX Improvement:**
    -   อาจเพิ่ม Dropdown list สำหรับช่องที่มีค่าที่เลือกได้แน่นอน (เช่น `Physicalstate`) เพื่อลดความผิดพลาดในการกรอกข้อมูล
    -   จัดกลุ่มข้อมูลบนหน้าจอให้เป็นระเบียบมากขึ้น อาจใช้ `TabControl` เพื่อแบ่งหมวดหมู่ให้ชัดเจนขึ้น

## ผู้พัฒนา (Author)

* **ชื่อ:** นพรัตน์ ทองเนื้อแปด (ก้อง)
* **ตำแหน่ง:** โปรแกรมเมอร์
