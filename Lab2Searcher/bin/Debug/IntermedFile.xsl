<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
<xsl:template match="read_books">
  <HTML>
    <BODY>
      <TABLE BORDER="2">
        <TR>
            <TD>Title</TD>
            <TD>Author</TD>
            <TD>Genre</TD>
            <TD>First publication</TD>
            <TD>Country</TD>
        </TR>
        <xsl:apply-templates select="book"/>
      </TABLE>
    </BODY>
  </HTML>
</xsl:template>
<xsl:template match="book">
  <TR>
    <TD><xsl:value-of select="title"/></TD>
    <TD><xsl:value-of select="author"/></TD>
    <TD><xsl:value-of select="genre"/></TD>
    <TD><xsl:value-of select="first_publication"/></TD>
    <TD><xsl:value-of select="country"/></TD>
  </TR>
</xsl:template>
</xsl:stylesheet>