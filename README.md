## Model to XML and XML to Model Converter
XmlHelper to convert from Model to XML and Vise-versa. 

Following extension methods are available
1. **ToXml()** - Extension method for converting Model to an XML string
2. **ToModel&lt;T&gt;()** - Generic Extension Method creating a Model from the XML string
3. **IsValidXml()** - Validate whether the provided XML string is Valid

### Convert Model to XML using XmlSerializer
Converting a Model to an XML string, use **ToXml()**

```markdown
var news = new NewsModel()
{
  Id = 10,
  Title = "Converting model to XML",
  NewsDate = DateTime.Today,
  Body = "<p>To convert, I use &nbsp;<em>XmlSerializer</em> to serialize.</p>"
};

string xml = news.ToXml(); //Use, ToXml() extension to convert the Model to an XML string.
```

### Convert XML to Model using XmlSerializer
Converting an XML string to a Model, use **ToModel<T>()**

```markdown
var xml = "<News xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">" +
		  		"<Id>10</Id>" +
		  		"<Title>Converting model to XML</Title>" +
		  		"<Date>2017-08-27T00:00:00+02:00</Date>" +
		  		"<Body>&lt;p&gt;To convert, I use &amp;nbsp;&lt;em&gt;XmlSerializer&lt;/em&gt; to serialize.&lt;/p&gt;</Body>" +
		  		"</News>";

var model = xml.ToModel<NewsModel>(); // Mapping the Model to the Generic ToModel<T>; extension will convert an XML string to a Model. 
```

### Validate XML
Validate the XML string by calling the **IsValidXml()** extension.

```markdown
var xml = "<News xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">" +
		  		"<Id>10</Id>" +
		  		"<Title>Converting model to XML</Title>" +
		  		"<Date>2017-08-27T00:00:00+02:00</Date>" +
		  		"<Body>&lt;p&gt;To convert, I use &amp;nbsp;&lt;em&gt;XmlSerializer&lt;/em&gt; to serialize.&lt;/p&gt;</Body>" +
		  		"</News>";

var isValid = xml.IsValidXml(); // to check whether the XML is Valid.
```

###### Authors and Contributors
Sanal Menon Kalipurayath ([https://www.twitter.com/sanalmenon](@sanalmenon))<br/>
Web: [http://sanal.menon.me](sanal.menon.me)<br/>
LinkedIn: [https://in.linkedin.com/menon](https://in.linkedin.com/menon)<br/>
Twitter: [https://www.twitter.com/sanalmenon](https://www.twitter.com/sanalmenon)<br/>
