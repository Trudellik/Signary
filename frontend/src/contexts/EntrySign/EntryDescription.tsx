import React from 'react';
import HandshapeIcon from './IconInfo/HandshapeIcon';
import HandsUsageIcon from './IconInfo/HandsUsageIcon';
import ArticleCountIcon from './IconInfo/ArticleCountIcon';

import './EntrySign.css';

const EntryDescription = () => {
  return (
    <div className="description">
      <HandshapeIcon handshape="b" />
      <HandsUsageIcon handsUsage="super-sub" />
      <ArticleCountIcon articles={['text', 'dummy']} />
    </div>
  );
};

export default EntryDescription;
