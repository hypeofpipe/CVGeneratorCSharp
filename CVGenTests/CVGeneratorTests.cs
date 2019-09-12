using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CVGen;

namespace CVGenTests
{
    [TestClass]
    public class CVGeneratorTests
    {
        [TestMethod]
        public void HTMLToPDFTest()
        {
            var html = "<div>{{somedata}}</div>";
            var cvGen = new CvGenerator();
            Assert.IsInstanceOfType(cvGen.HTMLToPDF(html), typeof(IronPdf.PdfDocument));
        }
        [TestMethod]
        public void RenderCVTest()
        {
            var html = "<div>{{INPUTDATA}}</div>";
            var data = new
            {
                INPUTDATA = "thatstestdata"
            };
            var cvGen = new CvGenerator();

            var result = cvGen.RenderCV(data, html);

            Assert.AreEqual(result, "<div>thatstestdata</div>");
        }
    }
}
