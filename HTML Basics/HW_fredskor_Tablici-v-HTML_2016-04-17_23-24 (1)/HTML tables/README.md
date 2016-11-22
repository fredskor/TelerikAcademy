<article class="markdown-body entry-content" itemprop="text">



<h1><a id="user-content-html-tables" class="anchor" href="#html-tables" aria-hidden="true"><svg aria-hidden="true" class="octicon octicon-link" height="16" version="1.1" viewBox="0 0 16 16" width="16"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a>HTML Tables</h1>









<div>
    <p>HTML Basics</p>
    <p>Telerik Software Academy</p>
    <a href="https://telerikacademy.com">https://telerikacademy.com</a>
</div>





<h1><a id="user-content-contents" class="anchor" href="#contents" aria-hidden="true"><svg aria-hidden="true" class="octicon octicon-link" height="16" version="1.1" viewBox="0 0 16 16" width="16"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a>Contents</h1>

<ul>
<li><a href="#/tables">HTML Tables</a>

<ul>
<li><a href="#/simpletables">Simple Tables</a></li>
<li><a href="#/headers">Data cells and Header cells</a></li>
<li><a href="#/completetables">Complete HTML Tables</a></li>
</ul></li>
<li><a href="#/nestedtables">Nested Tables</a></li>
<li><a href="#/comlextables">Complex tables</a>

<ul>
<li><a href="#/cells">Cell Spacing and Padding</a></li>
<li><a href="#/spans">Column and Row Span</a></li>
</ul></li>
</ul>

















<h1><a id="user-content-html-tables-1" class="anchor" href="#html-tables-1" aria-hidden="true"><svg aria-hidden="true" class="octicon octicon-link" height="16" version="1.1" viewBox="0 0 16 16" width="16"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a><a id="user-content-tables"></a>HTML Tables</h1>

<ul>
<li>Tables represent tabular data

<ul>
<li>A table consists of one or several rows</li>
<li>Each row has one or more columns</li>
</ul></li>
<li>Tables are comprised of several core tags:

<ul>
<li><code>&lt;table&gt;&lt;/table&gt;</code>:  begin/end table definition</li>
<li><code>&lt;tr&gt;&lt;/tr&gt;</code>: create a table row</li>
<li><code>&lt;td&gt;&lt;/td&gt;</code>: create tabular data (cell)</li>
</ul></li>
<li>Tables should not be used for layout

<ul>
<li>Use CSS floats and positioning styles instead</li>
</ul></li>
</ul>



<h1><a id="user-content-simple-html-tables--example" class="anchor" href="#simple-html-tables--example" aria-hidden="true"><svg aria-hidden="true" class="octicon octicon-link" height="16" version="1.1" viewBox="0 0 16 16" width="16"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a><a id="user-content-simpletables"></a>Simple HTML Tables – <em>Example</em></h1>

<div class="highlight highlight-text-html-basic"><pre>&lt;<span class="pl-ent">table</span> <span class="pl-e">cellspacing</span>=<span class="pl-s"><span class="pl-pds">"</span>0<span class="pl-pds">"</span></span> <span class="pl-e">cellpadding</span>=<span class="pl-s"><span class="pl-pds">"</span>5<span class="pl-pds">"</span></span>&gt;
  &lt;<span class="pl-ent">tr</span>&gt;
    &lt;<span class="pl-ent">td</span>&gt;&lt;<span class="pl-ent">img</span> <span class="pl-e">src</span>=<span class="pl-s"><span class="pl-pds">"</span>ppt.gif<span class="pl-pds">"</span></span>&gt;&lt;/<span class="pl-ent">td</span>&gt;
    &lt;<span class="pl-ent">td</span>&gt;&lt;<span class="pl-ent">a</span> <span class="pl-e">href</span>=<span class="pl-s"><span class="pl-pds">"</span>lecture1.ppt<span class="pl-pds">"</span></span>&gt;Lecture 1&lt;/<span class="pl-ent">a</span>&gt;&lt;/<span class="pl-ent">td</span>&gt;
  &lt;/<span class="pl-ent">tr</span>&gt;
  &lt;<span class="pl-ent">tr</span>&gt;
    &lt;<span class="pl-ent">td</span>&gt;&lt;<span class="pl-ent">img</span> <span class="pl-e">src</span>=<span class="pl-s"><span class="pl-pds">"</span>ppt.gif<span class="pl-pds">"</span></span>&gt;&lt;/<span class="pl-ent">td</span>&gt;
    &lt;<span class="pl-ent">td</span>&gt;&lt;<span class="pl-ent">a</span> <span class="pl-e">href</span>=<span class="pl-s"><span class="pl-pds">"</span>lecture2.ppt<span class="pl-pds">"</span></span>&gt;Lecture 2&lt;/<span class="pl-ent">a</span>&gt;&lt;/<span class="pl-ent">td</span>&gt;
  &lt;/<span class="pl-ent">tr</span>&gt;
  &lt;<span class="pl-ent">tr</span>&gt;
    &lt;<span class="pl-ent">td</span>&gt;&lt;<span class="pl-ent">img</span> <span class="pl-e">src</span>=<span class="pl-s"><span class="pl-pds">"</span>zip.gif<span class="pl-pds">"</span></span>&gt;&lt;/<span class="pl-ent">td</span>&gt;
    &lt;<span class="pl-ent">td</span>&gt;
      &lt;<span class="pl-ent">a</span> <span class="pl-e">href</span>=<span class="pl-s"><span class="pl-pds">"</span>lecture2-demos.zip<span class="pl-pds">"</span></span>&gt;Lecture 2 - Demos&lt;/<span class="pl-ent">a</span>&gt;
      &lt;/<span class="pl-ent">td</span>&gt;
  &lt;/<span class="pl-ent">tr</span>&gt;
&lt;/<span class="pl-ent">table</span>&gt;</pre></div>





<h2><a id="user-content-demo" class="anchor" href="#demo" aria-hidden="true"><svg aria-hidden="true" class="octicon octicon-link" height="16" version="1.1" viewBox="0 0 16 16" width="16"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a><a href="https://github.com/TelerikAcademy/HTML/tree/master/Topics/03.%20HTML-Tables/demos/1.%20Simple-tables.html">Demo</a></h2>











<h1><a id="user-content-data-cells-and-header-cells" class="anchor" href="#data-cells-and-header-cells" aria-hidden="true"><svg aria-hidden="true" class="octicon octicon-link" height="16" version="1.1" viewBox="0 0 16 16" width="16"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a><a id="user-content-headers"></a>Data Cells and Header Cells</h1>

<ul>
<li>Two kinds of cells in HTML tables

<ul>
<li><code>Data</code> cells – containing the table data</li>
<li><code>Header</code> cells – used for the column names or some more important cells</li>
</ul></li>
<li>Why two kinds of cells?

<ul>
<li>Used to <code>semantically</code> separate the cells</li>
</ul></li>
</ul>

<div class="highlight highlight-text-html-basic"><pre>&lt;<span class="pl-ent">tr</span>&gt;
    &lt;<span class="pl-ent">th</span>&gt;Full Name&lt;/<span class="pl-ent">th</span>&gt; &lt;<span class="pl-ent">th</span>&gt;Mark&lt;/<span class="pl-ent">th</span>&gt;
&lt;/<span class="pl-ent">tr</span>&gt;
&lt;<span class="pl-ent">tr</span>&gt;
    &lt;<span class="pl-ent">td</span>&gt;Doncho Minkov&lt;/<span class="pl-ent">td</span>&gt; &lt;<span class="pl-ent">td</span>&gt;Very good (5)&lt;/<span class="pl-ent">td</span>&gt;
&lt;/<span class="pl-ent">tr</span>&gt;
&lt;<span class="pl-ent">tr</span>&gt;
    &lt;<span class="pl-ent">td</span>&gt;Georgi Georgiev&lt;/<span class="pl-ent">td</span>&gt; &lt;<span class="pl-ent">td</span>&gt;Excellent (6)&lt;/<span class="pl-ent">td</span>&gt;
&lt;/<span class="pl-ent">tr</span>&gt;</pre></div>





<h2><a id="user-content-demo-1" class="anchor" href="#demo-1" aria-hidden="true"><svg aria-hidden="true" class="octicon octicon-link" height="16" version="1.1" viewBox="0 0 16 16" width="16"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a><a href="https://github.com/TelerikAcademy/HTML/tree/master/Topics/03.%20HTML-Tables/demos/2.%20Data-and-header-cells.html">Demo</a></h2>









<h1><a id="user-content-complete-html-tables" class="anchor" href="#complete-html-tables" aria-hidden="true"><svg aria-hidden="true" class="octicon octicon-link" height="16" version="1.1" viewBox="0 0 16 16" width="16"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a><a id="user-content-completetables"></a>Complete HTML Tables</h1>

<h2><a id="user-content-with-header-footer-and-body" class="anchor" href="#with-header-footer-and-body" aria-hidden="true"><svg aria-hidden="true" class="octicon octicon-link" height="16" version="1.1" viewBox="0 0 16 16" width="16"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a>With Header, Footer and Body</h2>





<h1><a id="user-content-complete-html-tables-1" class="anchor" href="#complete-html-tables-1" aria-hidden="true"><svg aria-hidden="true" class="octicon octicon-link" height="16" version="1.1" viewBox="0 0 16 16" width="16"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a>Complete HTML Tables</h1>

<ul>
<li>Table rows split into three semantic sections: <code>header</code>, <code>body</code> and <code>footer</code>

<ul>
<li><code>&lt;thead&gt;</code> denotes table header and contains <code>&lt;th&gt;</code> elements, instead of <code>&lt;td&gt;</code> elements</li>
<li><code>&lt;tbody&gt;</code> denotes collection of table rows that contain the very data</li>
<li><code>&lt;tfoot&gt;</code> denotes table footer but comes <strong>BEFORE</strong> the <code>&lt;tbody&gt;</code> tag</li>
<li><code>&lt;colgroup&gt;</code> and <code>&lt;col&gt;</code> define columns (used to set column widths)</li>
</ul></li>
</ul>



<h1><a id="user-content-complete-html-table-example" class="anchor" href="#complete-html-table-example" aria-hidden="true"><svg aria-hidden="true" class="octicon octicon-link" height="16" version="1.1" viewBox="0 0 16 16" width="16"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a>Complete HTML Table: <em>Example</em></h1>

<div class="highlight highlight-text-html-basic"><pre>&lt;<span class="pl-ent">table</span>&gt;
  &lt;<span class="pl-ent">colgroup</span>&gt;
    &lt;<span class="pl-ent">col</span> <span class="pl-e">style</span>=<span class="pl-s"><span class="pl-pds">"</span>width:100px<span class="pl-pds">"</span></span> /&gt;&lt;<span class="pl-ent">col</span> /&gt;
  &lt;/<span class="pl-ent">colgroup</span>&gt;
  &lt;<span class="pl-ent">thead</span>&gt;
    &lt;<span class="pl-ent">tr</span>&gt;&lt;<span class="pl-ent">th</span>&gt;Column 1&lt;/<span class="pl-ent">th</span>&gt;&lt;<span class="pl-ent">th</span>&gt;Column 2&lt;/<span class="pl-ent">th</span>&gt;&lt;/<span class="pl-ent">tr</span>&gt;
  &lt;/<span class="pl-ent">thead</span>&gt;
  &lt;<span class="pl-ent">tfoot</span>&gt;
    &lt;<span class="pl-ent">tr</span>&gt;&lt;<span class="pl-ent">td</span>&gt;Footer 1&lt;/<span class="pl-ent">td</span>&gt;&lt;<span class="pl-ent">td</span>&gt;Footer 2&lt;/<span class="pl-ent">td</span>&gt;&lt;/<span class="pl-ent">tr</span>&gt;
  &lt;/<span class="pl-ent">tfoot</span>&gt;
  &lt;<span class="pl-ent">tbody</span>&gt;
    &lt;<span class="pl-ent">tr</span>&gt;&lt;<span class="pl-ent">td</span>&gt;Cell 1.1&lt;/<span class="pl-ent">td</span>&gt;&lt;<span class="pl-ent">td</span>&gt;Cell 1.2&lt;/<span class="pl-ent">td</span>&gt;&lt;/<span class="pl-ent">tr</span>&gt;
    &lt;<span class="pl-ent">tr</span>&gt;&lt;<span class="pl-ent">td</span>&gt;Cell 2.1&lt;/<span class="pl-ent">td</span>&gt;&lt;<span class="pl-ent">td</span>&gt;Cell 2.2&lt;/<span class="pl-ent">td</span>&gt;&lt;/<span class="pl-ent">tr</span>&gt;
  &lt;/<span class="pl-ent">tbody</span>&gt;
&lt;/<span class="pl-ent">table</span>&gt;</pre></div>



<h1><a id="user-content-complete-html-table-example-1" class="anchor" href="#complete-html-table-example-1" aria-hidden="true"><svg aria-hidden="true" class="octicon octicon-link" height="16" version="1.1" viewBox="0 0 16 16" width="16"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a>Complete HTML Table: <em>Example</em></h1>

<div class="highlight highlight-text-html-basic"><pre>&lt;<span class="pl-ent">table</span>&gt;
  &lt;<span class="pl-ent">colgroup</span>&gt;
    &lt;<span class="pl-ent">col</span> <span class="pl-e">style</span>=<span class="pl-s"><span class="pl-pds">"</span>width:200px<span class="pl-pds">"</span></span> /&gt;&lt;<span class="pl-ent">col</span> /&gt;
  &lt;/<span class="pl-ent">colgroup</span>&gt;
  &lt;<span class="pl-ent">thead</span>&gt;
    &lt;<span class="pl-ent">tr</span>&gt;&lt;<span class="pl-ent">th</span>&gt;Column 1&lt;/<span class="pl-ent">th</span>&gt;&lt;<span class="pl-ent">th</span>&gt;Column 2&lt;/<span class="pl-ent">th</span>&gt;&lt;/<span class="pl-ent">tr</span>&gt;
  &lt;/<span class="pl-ent">thead</span>&gt;
  &lt;<span class="pl-ent">tfoot</span>&gt;
    &lt;<span class="pl-ent">tr</span>&gt;&lt;<span class="pl-ent">td</span>&gt;Footer 1&lt;/<span class="pl-ent">td</span>&gt;&lt;<span class="pl-ent">td</span>&gt;Footer 2&lt;/<span class="pl-ent">td</span>&gt;&lt;/<span class="pl-ent">tr</span>&gt;
  &lt;/<span class="pl-ent">tfoot</span>&gt;
  &lt;<span class="pl-ent">tbody</span>&gt;
    &lt;<span class="pl-ent">tr</span>&gt;&lt;<span class="pl-ent">td</span>&gt;Cell 1.1&lt;/<span class="pl-ent">td</span>&gt;&lt;<span class="pl-ent">td</span>&gt;Cell 1.2&lt;/<span class="pl-ent">td</span>&gt;&lt;/<span class="pl-ent">tr</span>&gt;
    &lt;<span class="pl-ent">tr</span>&gt;&lt;<span class="pl-ent">td</span>&gt;Cell 2.1&lt;/<span class="pl-ent">td</span>&gt;&lt;<span class="pl-ent">td</span>&gt;Cell 2.2&lt;/<span class="pl-ent">td</span>&gt;&lt;/<span class="pl-ent">tr</span>&gt;
  &lt;/<span class="pl-ent">tbody</span>&gt;
&lt;/<span class="pl-ent">table</span>&gt;</pre></div>

<div>Although the footer is before the data in the code, it is displayed last</div>







<h2><a id="user-content-demo-2" class="anchor" href="#demo-2" aria-hidden="true"><svg aria-hidden="true" class="octicon octicon-link" height="16" version="1.1" viewBox="0 0 16 16" width="16"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a><a href="https://github.com/TelerikAcademy/HTML/tree/master/Topics/03.%20HTML-Tables/demos/3.%20Complete-tables.html">Demo</a></h2>









<h1><a id="user-content-nested-tables" class="anchor" href="#nested-tables" aria-hidden="true"><svg aria-hidden="true" class="octicon octicon-link" height="16" version="1.1" viewBox="0 0 16 16" width="16"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a><a id="user-content-nestedtables"></a>Nested Tables</h1>

<h2><a id="user-content-tables-in-tables-in-tables-in-tables" class="anchor" href="#tables-in-tables-in-tables-in-tables" aria-hidden="true"><svg aria-hidden="true" class="octicon octicon-link" height="16" version="1.1" viewBox="0 0 16 16" width="16"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a>Tables in Tables in Tables in Tables…</h2>







<h1><a id="user-content-nested-tables-1" class="anchor" href="#nested-tables-1" aria-hidden="true"><svg aria-hidden="true" class="octicon octicon-link" height="16" version="1.1" viewBox="0 0 16 16" width="16"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a>Nested Tables</h1>

<ul>
<li>Table <strong>cells</strong> (<code>&lt;td&gt;</code>) can contain <strong>nested</strong> tables (tables within tables):</li>
</ul>

<div class="highlight highlight-text-html-basic"><pre>&lt;<span class="pl-ent">table</span>&gt;
  &lt;<span class="pl-ent">tr</span>&gt;
    &lt;<span class="pl-ent">td</span>&gt;Contact:&lt;/<span class="pl-ent">td</span>&gt;
    &lt;<span class="pl-ent">td</span>&gt;
      &lt;<span class="pl-ent">table</span>&gt;
        &lt;<span class="pl-ent">tr</span>&gt;
          &lt;<span class="pl-ent">td</span>&gt;First Name&lt;/<span class="pl-ent">td</span>&gt;
          &lt;<span class="pl-ent">td</span>&gt;Last Name&lt;/<span class="pl-ent">td</span>&gt;
        &lt;/<span class="pl-ent">tr</span>&gt;
      &lt;/<span class="pl-ent">table</span>&gt;
    &lt;/<span class="pl-ent">td</span>&gt;
  &lt;/<span class="pl-ent">tr</span>&gt;
&lt;/<span class="pl-ent">table</span>&gt;</pre></div>







<h2><a id="user-content-demo-3" class="anchor" href="#demo-3" aria-hidden="true"><svg aria-hidden="true" class="octicon octicon-link" height="16" version="1.1" viewBox="0 0 16 16" width="16"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a><a href="https://github.com/TelerikAcademy/HTML/tree/master/Topics/03.%20HTML-Tables/demos/4.%20Nested-tables.html">Demo</a></h2>

















<h1><a id="user-content--cell-spacing-and-padding" class="anchor" href="#-cell-spacing-and-padding" aria-hidden="true"><svg aria-hidden="true" class="octicon octicon-link" height="16" version="1.1" viewBox="0 0 16 16" width="16"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a><a id="user-content-cells"></a> Cell Spacing and Padding</h1>

<div>
  <div>cell spacing</div>
  <div>cell padding</div>
</div>





<h1><a id="user-content-cell-spacing-and-padding--example" class="anchor" href="#cell-spacing-and-padding--example" aria-hidden="true"><svg aria-hidden="true" class="octicon octicon-link" height="16" version="1.1" viewBox="0 0 16 16" width="16"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a>Cell Spacing and Padding – <em>Example</em></h1>

<div class="highlight highlight-text-html-basic"><pre>&lt;<span class="pl-ent">html</span>&gt;
  &lt;<span class="pl-ent">head</span>&gt;&lt;<span class="pl-ent">title</span>&gt;Table Cells&lt;/<span class="pl-ent">title</span>&gt;&lt;/<span class="pl-ent">head</span>&gt;
  &lt;<span class="pl-ent">body</span>&gt;
    &lt;<span class="pl-ent">table</span> <span class="pl-e">cellspacing</span>=<span class="pl-s"><span class="pl-pds">"</span>15<span class="pl-pds">"</span></span> <span class="pl-e">cellpadding</span>=<span class="pl-s"><span class="pl-pds">"</span>0<span class="pl-pds">"</span></span>&gt;
      &lt;<span class="pl-ent">tr</span>&gt;
          &lt;<span class="pl-ent">td</span>&gt;First&lt;/<span class="pl-ent">td</span>&gt;
          &lt;<span class="pl-ent">td</span>&gt;Second&lt;/<span class="pl-ent">td</span>&gt;
      &lt;/<span class="pl-ent">tr</span>&gt;
    &lt;/<span class="pl-ent">table</span>&gt;
    &lt;<span class="pl-ent">br</span>/&gt;
    &lt;<span class="pl-ent">table</span> <span class="pl-e">cellspacing</span>=<span class="pl-s"><span class="pl-pds">"</span>0<span class="pl-pds">"</span></span> <span class="pl-e">cellpadding</span>=<span class="pl-s"><span class="pl-pds">"</span>10<span class="pl-pds">"</span></span>&gt;
      &lt;<span class="pl-ent">tr</span>&gt;
          &lt;<span class="pl-ent">td</span>&gt;First&lt;/<span class="pl-ent">td</span>&gt;
          &lt;<span class="pl-ent">td</span>&gt;Second&lt;/<span class="pl-ent">td</span>&gt;
      &lt;/<span class="pl-ent">tr</span>&gt;
    &lt;/<span class="pl-ent">table</span>&gt;
  &lt;/<span class="pl-ent">body</span>&gt;
&lt;/<span class="pl-ent">html</span>&gt;</pre></div>





<div class="highlight highlight-text-html-basic"><pre>&lt;<span class="pl-ent">html</span>&gt;
  &lt;<span class="pl-ent">head</span>&gt;&lt;<span class="pl-ent">title</span>&gt;Table Cells&lt;/<span class="pl-ent">title</span>&gt;&lt;/<span class="pl-ent">head</span>&gt;
  &lt;<span class="pl-ent">body</span>&gt;
    &lt;<span class="pl-ent">table</span> <span class="pl-e">cellspacing</span>=<span class="pl-s"><span class="pl-pds">"</span>15<span class="pl-pds">"</span></span> <span class="pl-e">cellpadding</span>=<span class="pl-s"><span class="pl-pds">"</span>0<span class="pl-pds">"</span></span>&gt;
      &lt;<span class="pl-ent">tr</span>&gt;
          &lt;<span class="pl-ent">td</span>&gt;First&lt;/<span class="pl-ent">td</span>&gt;
          &lt;<span class="pl-ent">td</span>&gt;Second&lt;/<span class="pl-ent">td</span>&gt;
      &lt;/<span class="pl-ent">tr</span>&gt;
    &lt;/<span class="pl-ent">table</span>&gt;
    &lt;<span class="pl-ent">br</span>/&gt;
    &lt;<span class="pl-ent">table</span> <span class="pl-e">cellspacing</span>=<span class="pl-s"><span class="pl-pds">"</span>0<span class="pl-pds">"</span></span> <span class="pl-e">cellpadding</span>=<span class="pl-s"><span class="pl-pds">"</span>10<span class="pl-pds">"</span></span>&gt;
      &lt;<span class="pl-ent">tr</span>&gt;
          &lt;<span class="pl-ent">td</span>&gt;First&lt;/<span class="pl-ent">td</span>&gt;
          &lt;<span class="pl-ent">td</span>&gt;Second&lt;/<span class="pl-ent">td</span>&gt;
      &lt;/<span class="pl-ent">tr</span>&gt;
    &lt;/<span class="pl-ent">table</span>&gt;
  &lt;/<span class="pl-ent">body</span>&gt;
&lt;/<span class="pl-ent">html</span>&gt;</pre></div>







<h2><a id="user-content-demo-4" class="anchor" href="#demo-4" aria-hidden="true"><svg aria-hidden="true" class="octicon octicon-link" height="16" version="1.1" viewBox="0 0 16 16" width="16"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a><a href="https://github.com/TelerikAcademy/HTML/tree/master/Topics/03.%20HTML-Tables/demos/5.%20Table-cells-spacing-padding.html">Demo</a></h2>











<h1><a id="user-content-row-and-column-spans" class="anchor" href="#row-and-column-spans" aria-hidden="true"><svg aria-hidden="true" class="octicon octicon-link" height="16" version="1.1" viewBox="0 0 16 16" width="16"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a><a id="user-content-spans"></a>Row and Column Spans</h1>

<h2><a id="user-content-how-to-make-a-two-cells-column-or-row" class="anchor" href="#how-to-make-a-two-cells-column-or-row" aria-hidden="true"><svg aria-hidden="true" class="octicon octicon-link" height="16" version="1.1" viewBox="0 0 16 16" width="16"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a>How to Make a Two-Cells Column or Row?</h2>















<div class="highlight highlight-text-html-basic"><pre>&lt;<span class="pl-ent">table</span> <span class="pl-e">cellspacing</span>=<span class="pl-s"><span class="pl-pds">"</span>0<span class="pl-pds">"</span></span>&gt;
  &lt;<span class="pl-ent">tr</span> <span class="pl-e">class</span>=<span class="pl-s"><span class="pl-pds">"</span>1<span class="pl-pds">"</span></span>&gt;
    &lt;<span class="pl-ent">td</span>&gt;Cell[1,1]&lt;/<span class="pl-ent">td</span>&gt;
    &lt;<span class="pl-ent">td</span> <span class="pl-e">colspan</span>=<span class="pl-s"><span class="pl-pds">"</span>2<span class="pl-pds">"</span></span>&gt;Cell[2,1]&lt;/<span class="pl-ent">td</span>&gt;
  &lt;/<span class="pl-ent">tr</span>&gt;
  &lt;<span class="pl-ent">tr</span> <span class="pl-e">class</span>=<span class="pl-s"><span class="pl-pds">"</span>2<span class="pl-pds">"</span></span>&gt;
    &lt;<span class="pl-ent">td</span>&gt;Cell[1,2]&lt;/<span class="pl-ent">td</span>&gt;
    &lt;<span class="pl-ent">td</span> <span class="pl-e">rowspan</span>=<span class="pl-s"><span class="pl-pds">"</span>2<span class="pl-pds">"</span></span>&gt;Cell[2,2]&lt;/<span class="pl-ent">td</span>&gt;
    &lt;<span class="pl-ent">td</span>&gt;Cell[3,2]&lt;/<span class="pl-ent">td</span>&gt;
  &lt;/<span class="pl-ent">tr</span>&gt;
  &lt;<span class="pl-ent">tr</span> <span class="pl-e">class</span>=<span class="pl-s"><span class="pl-pds">"</span>3<span class="pl-pds">"</span></span>&gt;
    &lt;<span class="pl-ent">td</span>&gt;Cell[1,3]&lt;/<span class="pl-ent">td</span>&gt;
    &lt;<span class="pl-ent">td</span>&gt;Cell[2,3]&lt;/<span class="pl-ent">td</span>&gt;
  &lt;/<span class="pl-ent">tr</span>&gt;
&lt;/<span class="pl-ent">table</span>&gt;</pre></div>







<h2><a id="user-content-demo-5" class="anchor" href="#demo-5" aria-hidden="true"><svg aria-hidden="true" class="octicon octicon-link" height="16" version="1.1" viewBox="0 0 16 16" width="16"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a><a href="https://github.com/TelerikAcademy/HTML/tree/master/Topics/03.%20HTML-Tables/demos/6.%20Table-colspan-rowspan.html">Demo</a></h2>













<h1><a id="user-content-free-trainings--telerik-academy" class="anchor" href="#free-trainings--telerik-academy" aria-hidden="true"><svg aria-hidden="true" class="octicon octicon-link" height="16" version="1.1" viewBox="0 0 16 16" width="16"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a>Free Trainings @ Telerik Academy</h1>

<ul>
<li>Web front-end track

<ul>
<li><a href="http://academy.telerik.com/student-courses/web-design-and-ui/about">html.telerik.com</a></li>
<li>Telerik Software Academy

<ul>
<li><a href="https://telerikacademy.com">telerikacademy.com</a></li>
</ul></li>
<li>Telerik Academy @ Facebook

<ul>
<li><a href="https://github.com/TelerikAcademy/HTML/blob/master/Topics/03.%20HTML-Tables/facebook.com/TelerikAcademy">facebook.com/TelerikAcademy</a></li>
</ul></li>
<li>Telerik Academy Learning System

<ul>
<li><a href="https://telerikacademy.com">telerikacademy.com</a></li>
</ul></li>
</ul></li>
</ul>
</article>