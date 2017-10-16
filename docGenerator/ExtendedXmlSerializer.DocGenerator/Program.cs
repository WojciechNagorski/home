﻿using System;
using System.IO;

namespace ExtendedXmlSerializer.DocGenerator
{
	class Program
	{
		// ReSharper disable once UnusedParameter.Local
		static void Main(string[] args)
		{
			ReStructuredText doc = new ReStructuredText();

			doc.AddHeader("Information");

			doc.Add("Support platforms:");
			doc.AddList(".NET 4.5", ".NET Platform Standard 1.6");
			doc.Add("Support features:");
			doc.AddList(
				"Deserialization xml from standard XMLSerializer",
				"Serialization class, struct, generic class, primitive type, generic list and dictionary, array, enum",
				"Serialization class with property interface",
				"Serialization circular reference and reference Id",
				"Deserialization of old version of xml",
				"Property encryption",
				"Custom serializer",
				"Support XmlElementAttribute and XmlRootAttribute",
				"POCO - all configurations (migrations, custom serializer...) are outside the clas");

			doc.Add("Standard XML Serializer in .NET is very limited:");
			doc.AddList(
				"Does not support serialization of class with circular reference or class with interface property.",
				"There is no mechanism for reading the old version of XML.",
				"Does not support properties that are defined with interface types.",
				"Does not support read-only properties (like Xaml does).",
				"If you want create custom serializer, your class must inherit from IXmlSerializable. This means that your class will not be a POCO class.",
				"Does not support IoC");

			doc.AddHeader("The Basics");
			doc.Add("Everything in ExtendedXmlSerializer begins with a configuration container, from which you can use to configure the serializer and ultimately create it:");
			doc.AddCode(@"..\..\..\..\samples\ExtendedXmlSerializer.Samples\Introduction\Create.cs", "Create");

			doc.Add("Using this simple subject class:");
			doc.AddCode(@"..\..\..\..\samples\ExtendedXmlSerializer.Samples\Introduction\Subject.cs", "Subject");

			doc.Add("The results of the default serializer will look like this:");
			doc.AddCode(@"..\..\..\..\samples\ExtendedXmlSerializer.Samples\bin\Introduction.xml", CodeFormat.Xml);

			doc.Add("We can take this a step further by configuring the `Subject`'s Type and Member properties, which will effect how its Xml is emitted.  Here is an example of configuring the `Subject`'s name to emit as `ModifiedSubject`:");
			doc.AddCode(@"..\..\..\..\samples\ExtendedXmlSerializer.Samples\Introduction\Type.cs", "Type");
			doc.AddCode(@"..\..\..\..\samples\ExtendedXmlSerializer.Samples\bin\Introduction.Type.xml", CodeFormat.Xml);

			doc.Add("Diving a bit further, we can also configure the type's member information.  For example, configuring `Subject.Message` to emit as `Text` instead:");
			doc.AddCode(@"..\..\..\..\samples\ExtendedXmlSerializer.Samples\Introduction\Member.cs", "Member");
			doc.AddCode(@"..\..\..\..\samples\ExtendedXmlSerializer.Samples\bin\Introduction.Member.xml", CodeFormat.Xml);


			doc.AddHeader("Serialization");
			doc.AddCode("..\\..\\..\\..\\samples\\ExtendedXmlSerializer.Samples\\Simple\\SimpleSamples.cs",
				"Serialization");

			doc.AddHeader("Deserialization");
			doc.AddCode("..\\..\\..\\..\\samples\\ExtendedXmlSerializer.Samples\\Simple\\SimpleSamples.cs",
				"Deserialization");

			doc.AddHeader("Serialization of dictionary");
			doc.Add("You can serialize generic dictionary, that can store any type.");
			doc.AddCode("..\\..\\..\\..\\samples\\ExtendedXmlSerializer.Samples\\Dictianary\\TestClass.cs", "TestClass");
			doc.AddCode("..\\..\\..\\..\\samples\\ExtendedXmlSerializer.Samples\\Dictianary\\DictianarySamples.cs", "InitDictionary");
			doc.Add("Output XML will look like:");
			doc.AddCode("..\\..\\..\\..\\samples\\ExtendedXmlSerializer.Samples\\bin\\DictianarySamples.xml", CodeFormat.Xml);
			doc.Add("If you use UseOptimizedNamespaces function xml will look like:");
			doc.AddCode("..\\..\\..\\..\\samples\\ExtendedXmlSerializer.Samples\\bin\\DictianarySamplesUseOptimizedNamespaces.xml", CodeFormat.Xml);

			doc.AddHeader("Custom serialization");
			doc.Add("If your class has to be serialized in a non-standard way:");
			doc.AddCode("..\\..\\..\\..\\samples\\ExtendedXmlSerializer.Samples\\CustomSerializator\\TestClass.cs", "CustomSerializator");
			doc.Add("You must create custom serializer:");
			doc.AddCode("..\\..\\..\\..\\samples\\ExtendedXmlSerializer.Samples\\CustomSerializator\\TestClassSerializer.cs", "TestClassSerializer");
			doc.Add("Then, you have to add custom serializer to configuration of TestClass:");
			doc.AddCode("..\\..\\..\\..\\samples\\ExtendedXmlSerializer.Samples\\CustomSerializator\\CustomSerializatorSamples.cs", "AddCustomSerializerToConfiguration");

			doc.AddHeader("Deserialize old version of xml");
			doc.Add("In standard XMLSerializer you can't deserialize XML in case you change model. In ExtendedXMLSerializer you can create migrator for each class separately. E.g.: If you have big class, that uses small class and this small class will be changed you can create migrator only for this small class. You don't have to modify whole big XML. Now I will show you a simple example:");
			doc.Add("If you had a class:");
			doc.AddCode("..\\..\\..\\..\\samples\\ExtendedXmlSerializer.Samples\\MigrationMap\\TestClass.cs", "FirstVersion");
			doc.Add("and generated XML look like:");
			doc.AddCode("..\\..\\..\\..\\samples\\ExtendedXmlSerializer.Samples\\MigrationMap\\TestClass.cs", "XmlFirstVersion", CodeFormat.Xml);
			doc.Add("Then you renamed property:");
			doc.AddCode("..\\..\\..\\..\\samples\\ExtendedXmlSerializer.Samples\\MigrationMap\\TestClass.cs", "SecondVersion");
			doc.Add("and generated XML look like:");
			doc.AddCode("..\\..\\..\\..\\samples\\ExtendedXmlSerializer.Samples\\MigrationMap\\TestClass.cs", "XmlSecondVersion", CodeFormat.Xml);
			doc.Add("Then, you added new property and you wanted to calculate a new value during deserialization.");
			doc.AddCode("..\\..\\..\\..\\samples\\ExtendedXmlSerializer.Samples\\MigrationMap\\TestClass.cs", "LastVersion");
			doc.Add("and new XML should look like:");
			doc.AddCode("..\\..\\..\\..\\samples\\ExtendedXmlSerializer.Samples\\bin\\XmlLastVersion.xml", CodeFormat.Xml);
			doc.Add("You can migrate (read) old version of XML using migrations:");
			doc.AddCode("..\\..\\..\\..\\samples\\ExtendedXmlSerializer.Samples\\MigrationMap\\TestClassMigrations.cs", "TestClassMigrations");
			doc.Add("Then, you must register your TestClassMigrations class in configuration");
			doc.AddCode("..\\..\\..\\..\\samples\\ExtendedXmlSerializer.Samples\\MigrationMap\\MigrationMapSamples.cs", "MigrationsConfiguration");

			doc.AddHeader("Object reference and circular reference");
			doc.Add("If you have a class:");
			doc.AddCode("..\\..\\..\\..\\samples\\ExtendedXmlSerializer.Samples\\ObjectReference\\Person.cs", "PersonClass");
			doc.Add("then you create object with circular reference, like this:");
			doc.AddCode("..\\..\\..\\..\\samples\\ExtendedXmlSerializer.Samples\\ObjectReference\\ObjectReferenceSamples.cs", "CreateObject");
			doc.Add("You must configure Person class as reference object:");
			doc.AddCode("..\\..\\..\\..\\samples\\ExtendedXmlSerializer.Samples\\ObjectReference\\ObjectReferenceSamples.cs", "Configure");
			doc.Add("Output XML will look like this:");
			doc.AddCode("..\\..\\..\\..\\samples\\ExtendedXmlSerializer.Samples\\bin\\ObjectReferenceSamples.xml", CodeFormat.Xml);

			doc.AddHeader("Property Encryption");
			doc.Add("If you have a class with a property that needs to be encrypted:");
			doc.AddCode("..\\..\\..\\..\\samples\\ExtendedXmlSerializer.Samples\\Encrypt\\Person.cs", "EncryptClass");
			doc.Add("You must implement interface IEncryption. For example, it will show the Base64 encoding, but in the real world better to use something safer, eg. RSA.:");
			doc.AddCode("..\\..\\..\\..\\samples\\ExtendedXmlSerializer.Samples\\Encrypt\\EncryptSamples.cs", "CustomEncryption");
			doc.Add("Then, you have to specify which properties are to be encrypted and register your IEncryption implementation.");
			doc.AddCode("..\\..\\..\\..\\samples\\ExtendedXmlSerializer.Samples\\Encrypt\\EncryptSamples.cs", "Configuration");

			doc.AddHeader("History");
			doc.AddList("2017-??-?? - v2.0.0 - Rewritten version");

			doc.AddHeader("Authors");
			doc.AddList(
				"`Wojciech Nagórski <https://github.com/wojtpl2>`__",
				"`Mike-EEE <https://github.com/Mike-EEE>`__"
			);

			var result = doc.ToString();

			File.WriteAllText("..\\..\\..\\..\\docs\\get-started\\index.rst", result);

			result =
				".. image:: https://img.shields.io/nuget/v/ExtendedXmlSerializer.svg" + Environment.NewLine + "    :target: https://www.nuget.org/packages/ExtendedXmlSerializer/" + Environment.NewLine +
				".. image:: https://ci.appveyor.com/api/projects/status/9u1w8cyyr22kbcwi?svg=true" + Environment.NewLine + "    :target: https://ci.appveyor.com/project/wojtpl2/extendedxmlserializer\n" + Environment.NewLine + Environment.NewLine +
			   result;

			File.WriteAllText("..\\..\\..\\..\\readme.rst", result);
		}
	}
}