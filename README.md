# Akkhie LabFlow

![LabFlow Icon](https://raw.githubusercontent.com/FortAwesome/Font-Awesome/6.x/svgs/solid/vial-virus.svg)

**Akkhie LabFlow** เป็นโปรแกรมเดสก์ท็อปสำหรับจัดการระบบงานภายในห้องปฏิบัติการทางการแพทย์ (ห้องแล็บ) ถูกพัฒนาขึ้นเพื่อช่วยเพิ่มประสิทธิภาพ ลดขั้นตอนที่ซ้ำซ้อน และลดความผิดพลาดจากการทำงานด้วยเอกสารแบบเดิมๆ

โปรแกรมครอบคลุมกระบวนการทำงานตั้งแต่การรับสิ่งส่งตรวจ, การจัดการข้อมูลผู้ป่วย, การบันทึกผลการทดสอบ, ไปจนถึงการออกรายงานผล

---

## 🚀 ฟีเจอร์หลัก (Features)

* **ระบบจัดการผู้ป่วย:** เพิ่ม, แก้ไข, ค้นหาข้อมูลผู้ป่วย
* **การจัดการคำสั่งตรวจ (Test Orders):** สร้างและติดตามรายการทดสอบสำหรับผู้ป่วยแต่ละราย
* **การบันทึกผลแล็บ:** บันทึกผลการทดสอบจากเครื่องมือวิเคราะห์หรือโดยผู้ใช้งาน
* **การพิมพ์รายงาน:** สร้างและพิมพ์ใบรายงานผลการตรวจในรูปแบบที่เป็นมาตรฐาน
* **การค้นหาและกรองข้อมูล:** ค้นหาข้อมูลย้อนหลังได้อย่างรวดเร็ว ทั้งจากข้อมูลผู้ป่วยและผลการตรวจ

---

## 🛠️ เทคโนโลยีที่ใช้ (Technology Stack)

* **Framework:** .NET Framework
* **Language:** C#
* **User Interface:** Windows Forms (WinForms)
* **Database:** Microsoft SQL Server (MSSQL)

---

## 📋 สิ่งที่ต้องมี (Prerequisites)

เพื่อให้สามารถรันโปรเจกต์นี้ได้ คุณจำเป็นต้องติดตั้งโปรแกรมต่อไปนี้ก่อน:

1.  **Visual Studio** (แนะนำเวอร์ชัน 2019 หรือใหม่กว่า)
    * ต้องติดตั้ง Workload **".NET desktop development"**
2.  **Microsoft SQL Server** (แนะนำเวอร์ชัน 2017 หรือใหม่กว่า)
    * สามารถใช้เวอร์ชัน Express, Developer, หรือ Standard ได้

---

## ⚙️ การติดตั้ง (Installation & Setup)

ทำตามขั้นตอนต่อไปนี้เพื่อตั้งค่าโปรเจกต์สำหรับเริ่มพัฒนา

1.  **Clone a repository:**
    ```bash
    git clone [https://github.com/](https://github.com/)[YourUsername]/Akkhie_LabFlow.git
    ```
    *(กรุณาแก้ไข `[YourUsername]` เป็นชื่อผู้ใช้ GitHub ของคุณ)*

2.  **เปิดโปรเจกต์ใน Visual Studio:**
    * ไปที่โฟลเดอร์ของโปรเจกต์ที่ clone มา
    * ดับเบิ้ลคลิกไฟล์ `LabFlow.sln` เพื่อเปิดโปรเจกต์

3.  **ตั้งค่าฐานข้อมูล (Database Setup):**
    * เปิด **SQL Server Management Studio (SSMS)** และสร้างฐานข้อมูลใหม่ (เช่น `LabFlowDB`)
    * (แนะนำ) คุณอาจจะต้องสร้างตารางตามที่กำหนดในไฟล์ `DataModels.cs`
    * เปิดไฟล์ `App.config` ในโปรเจกต์
    * แก้ไขส่วน `connectionStrings` ให้ชี้ไปยังฐานข้อมูลที่คุณสร้างไว้:
        ```xml
        <connectionStrings>
            <add name="YourConnectionStringName" 
                 connectionString="Data Source=YOUR_SERVER_NAME;Initial Catalog=LabFlowDB;Integrated Security=True;" 
                 providerName="System.Data.SqlClient" />
        </connectionStrings>
        ```
        * เปลี่ยน `YOUR_SERVER_NAME` เป็นชื่อ SQL Server instance ของคุณ
        * เปลี่ยน `LabFlowDB` เป็นชื่อฐานข้อมูลของคุณ
        * เปลี่ยน `YourConnectionStringName` ให้ตรงกับชื่อที่ใช้ในโค้ด

4.  **Build the Solution:**
    * ใน Visual Studio, คลิกขวาที่ Solution ในหน้า Solution Explorer และเลือก `Build Solution` (หรือ `Rebuild Solution`) เพื่อให้ Visual Studio ดาวน์โหลด Dependencies (NuGet packages) ที่จำเป็นทั้งหมด

5.  **Run the application:**
    * กดปุ่ม `Start` (ไอคอนสามเหลี่ยมสีเขียว) หรือกด `F5` เพื่อเริ่มการทำงานของโปรแกรม

---

## 🖼️ ภาพหน้าจอ (Screenshots)

*(แนะนำให้เพิ่มภาพหน้าจอของโปรแกรมที่นี่ เพื่อให้เห็นภาพรวมการทำงาน)*

ตัวอย่าง:
`[ภาพหน้าจอหลัก]`
`[ภาพหน้าจอการบันทึกผล]`

---

## 👨‍💻 ผู้พัฒนา (Author)

* **ชื่อ:** นพรัตน์ ทองเนื้อแปด (ก้อง)
* **ตำแหน่ง:** โปรแกรมเมอร์

