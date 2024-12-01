import React from 'react';
import './IconInfo.css';

interface ArticleCountIconProps {
  count: number;
}

const ArticleCountIcon: React.FC<ArticleCountIconProps> = ({ count }) => {
  return (
    <div className="facts">
      {count > 0 ? (
        <div className="article-count">{count}</div>
      ) : (
        <div className="article-count no-articles">No Articles</div>
      )}
    </div>
  );
};

export default ArticleCountIcon;
