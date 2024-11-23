import React from 'react';
import './IconInfo.css';

interface ArticleCountIconProps {
  articles: string[];
}

const ArticleCountIcon: React.FC<ArticleCountIconProps> = ({ articles }) => {
  const articleCount = articles.length;

  return (
    <div className="facts">
      {articleCount > 0 ? (
        <div className="article-count">{articleCount}</div>
      ) : (
        <div className="article-count no-articles">No Articles</div>
      )}
    </div>
  );
};

export default ArticleCountIcon;
