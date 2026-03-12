# Scanner Agent

## Overview
هو برنامج محلي يعمل على جهاز المستخدم ويتيح لأنظمة الويب تشغيل أجهزة الاسكانر عبر المتصفح.  
يمكن لأي نظام ويب استدعاؤه لمسح المستندات وعرضها أو رفعها إلى السيرفر.

## Scanner SDK Class Library
تحتوي على الكود المسؤول عن التعامل مع أجهزة الاسكنر، والغرض منها فصل منطق التعامل مع الاسكنر عن التطبيق نفسه بحيث يمكن إعادة استخدامها مع أي مشروع آخر.

وظيفتها:
- معرفة الأجهزة المتصلة
- تنفيذ عملية المسح
- إرجاع الصورة كبيانات

ويمكن تطويرها لاحقاً لإضافة إعدادات المسح مثل اللون والنوع وغيرها.

### يمكن إضافتها إلى
- Web API
- Windows Application
- Console Application

## Source Code
ScannerSdk

للإضافة أو التعديل على الكود.

## Architecture
Web System (Server) -> Browser -> Scanner Agent -> Scanner SDK -> Device

## Requirements
- Windows 10 أو أحدث
- .NET Runtime
- تعريف الاسكانر مثبت
- دعم WIA أو TWAIN

## Installation

1. انسخ مجلد البرنامج إلى الجهاز: Install/ScannerAgent/

2. شغّل البرنامج:
ScannerSdk.Aget.exe
3. افتح صفحة:
Scan.html

## API Endpoints

### Get Available Scanners
GET /api/scanner/devices

Example Response:

```json
[
  "HP ScanJet Pro 2500 f1"
]
GET /api/scanner/scan
Response:
image/jpeg
## Notes

- الاسكنر اجنت يجب أن يعمل على نفس جهاز المستخدم
- المتصفح هو الذي يتواصل مع الاجنت
- السيرفر لا يستطيع الوصول إلى localhost الخاص بالمستخدم
##Default Port
1616
##Local API
http://localhost:1616



